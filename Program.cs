List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Zetna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

// Execute Assignment Tasks here!
// first Chilean Eruption
IEnumerable<Eruption> Chilean = eruptions.Where(x => x.Location == "Chile");
PrintEach(Chilean, "Chilean Eruptions:");
// first Hawaiian Is Eruption
IEnumerable<Eruption> Hawaiian = eruptions.Where(y => y.Location == "Hawaiian Is");
if(Hawaiian == null){
    Console.WriteLine("No Hawaiian Eruption found.");
}
PrintEach(Hawaiian, "Hawaiian Eruptions:");
// first after 1900AD and in New Zealand
IEnumerable<Eruption> newZealand = eruptions.Where(z => z.Year > 1900 && z.Location == "New Zealand");
PrintEach(newZealand, "Eruptions after 1900 AD in New Zealand");

// find all where volcano's elevation is over 2000m
IEnumerable<Eruption> overTwoThousand = eruptions.Where(z => z.ElevationInMeters > 2000);
PrintEach(overTwoThousand, "Volcanoes over 2000m in Elevation:");

// find all where the volcano's name starts with a Z and print them+the number of eruptions found
IEnumerable<Eruption> zVolcanoes = eruptions.Where(y => y.Volcano.StartsWith("Z"));
int count = eruptions.Count(c=> c.Volcano.StartsWith("Z"));
Console.WriteLine(count + " eruption(s) found starting with Z.");
PrintEach(zVolcanoes, "Volcanoes starting with Z:");

// find highest elevation and print only that int (use linq to find max)
int highestElevation = eruptions.Max(m=> m.ElevationInMeters);
Console.WriteLine(highestElevation);

// use the highest elevation var to find and print the name of the volcano with that elevation
IEnumerable<Eruption> elevated = eruptions.Where(elev => elev.ElevationInMeters == highestElevation);
PrintEach(elevated, "This is the tallest Eruption!");

// print all volcanoes' names alphabetically
IEnumerable<Eruption> alphabetical = eruptions.OrderBy(p => p.Volcano);
PrintEach(alphabetical);

// print all eruptions that happened before the year 1000 ce alphabetically according to volcano name
IEnumerable<Eruption> ancient = eruptions.OrderBy(p => p.Volcano).Where(y => y.Year < 1000);
PrintEach(ancient, "Eruptions before 1000CE:");

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
