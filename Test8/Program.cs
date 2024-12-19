string path = @"C:\Data";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

ShowFileContent(lines);

static void ShowFileContent(string[] fileContentArray)
{
    int i = 1;
    foreach (string line in fileContentArray)
    {
        Console.WriteLine($"{i}. {line}");
        i++;
    }
}

//string path = @"C:\Data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
//Console.WriteLine(lines.Length);

//string path = @"C:\Data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
//Console.WriteLine(GetJoke(lines));

//static string GetJoke(string[] jokeArray)
//{
//    Random rnd = new Random();
//    return jokeArray[rnd.Next(0, jokeArray.Length)];
//}

//string path = @"C:\Data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(path + fileName);

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}

//string path = @"C:\Data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(path + fileName);

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}

//string path = @"C:\Data";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines($"{path} + {fileName}");

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}

//string path = @"C:\Data";
//string fileName = "chuck.txt";

//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

//foreach (string hero in lines)
//{
//    Console.WriteLine(hero);
//}
