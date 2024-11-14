// string [] leksaker = new string[5];
// leksaker[0] = "Lego";
// leksaker[1] = "Gosedjur";
// leksaker[2] = "Pussel";
// leksaker[3] = "Dockor";
// leksaker[4] = "Pokémon";

// // foreach (string leksak in leksaker)
// // {
// //     Console.WriteLine(leksak);
// // }

// // Console.ReadLine();

// string [] klasskamrater = {"Melis", "Elsa", "Teodora", "Amira", "Vilma"};

// int [] värden = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// for (int i = 0; i < klasskamrater.Length; i++)
// {
//     Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} värdet {värden[i]}");
// }

// Console.ReadLine();



List<string> cities = new List<string>();
string city = "";

while (city != "exit")
{
    city = Console.ReadLine();

    if (city != "exit")
    {
        cities.Add(city);
    }
}

foreach (var c in cities)
{
    Console.WriteLine(c);
}


Console.ReadLine();