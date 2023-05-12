string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

Console.Write("\nLINQ : Display the list according to the length then by name in ascending order : ");
Console.Write("\n--------------------------------------------------------------------------------\n");
Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");
Console.Write("\nHere is the arranged list :\n");
cities.OrderBy(c => c.Length).ThenBy(c => c).ToList().ForEach(c =>  Console.WriteLine(c));   