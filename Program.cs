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
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

// Task 1: Find the first eruption in Chile and print it.
Eruption firstEruptionInChile = eruptions.FirstOrDefault(e => e.Location == "Chile");
if (firstEruptionInChile != null)
{
    Console.WriteLine("First Eruption in Chile:\n" + firstEruptionInChile);
}
else
{
    Console.WriteLine("No Eruption found in Chile.");

}

// Task 2: Find the first eruption from the "Hawaiian Is" location and print it.
Eruption firstHawaiianEruption = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
if (firstHawaiianEruption != null)
{
    Console.WriteLine("First Hawaiian Is Eruption:\n" + firstHawaiianEruption);
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
}

// Task 3: Find the first eruption after the year 1900 and in "New Zealand" and print it.
Eruption firstEruptionAfter1900InNewZealand = eruptions.FirstOrDefault(e => e.Year > 1900 && e.Location == "New Zealand");
if (firstEruptionAfter1900InNewZealand != null)
{
    Console.WriteLine("First Eruption after 1900 in New Zealand:\n" + firstEruptionAfter1900InNewZealand);
}
else
{
    Console.WriteLine("No such eruption found.");
}

// Task 4: Find all eruptions with an elevation over 2000m and print them.
IEnumerable<Eruption> highElevationEruptions = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(highElevationEruptions, "Eruptions with elevation over 2000m.");

// Task 5: Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> eruptionsStartingWithL = eruptions.Where(e => e.Volcano.StartsWith("L"));
PrintEach(eruptionsStartingWithL, "Eruptions with volcano names starting with 'L'.");
Console.WriteLine($"Number of eruptions found: {eruptionsStartingWithL.Count()}");

// Task 6: Find the highest elevation and print only that integer.
int highestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine("Highest Elevation: " + highestElevation);

// Task 7: Use the highest elevation variable to find and print the name of the Volcano with that elevation.
string volcanoWithHighestElevation = eruptions.FirstOrDefault(e => e.ElevationInMeters == highestElevation)?.Volcano;
if (volcanoWithHighestElevation != null)
{
    Console.WriteLine("Volcano with the highest elevation: " + volcanoWithHighestElevation);
}

// Task 8: Print all volcano names alphabetically.
IEnumerable<string> sortedVolcanoNames = eruptions.Select(e => e.Volcano).OrderBy(name => name);
PrintEach(sortedVolcanoNames, "Volcano names alphabetically.");

// Task 9: Print all eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> eruptionsBeforeYear1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
PrintEach(eruptionsBeforeYear1000, "Eruptions before the year 1000 CE alphabetically.");

// Bonus: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
IEnumerable<string> volcanoNamesBeforeYear1000 = eruptionsBeforeYear1000.Select(e => e.Volcano);
PrintEach(volcanoNamesBeforeYear1000, "Volcano names before the year 1000 CE alphabetically.");

