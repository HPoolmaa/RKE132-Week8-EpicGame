//// 1 -----------
//string[] heroes = { "Benno", "Bruno", "Tilde", "Helary", "Kristina" };
//string[] villains = { "Väle kollane pall", "Pikk karvane uss", "Valge laksuv lint", "UPS leeki sülgav Draakon", "Näksav hiireke"};

//Random rnd = new Random();
//int randomIndex = rnd.Next(0, heroes.Length);

//string hero = heroes[randomIndex];

//randomIndex = rnd.Next(0, villains.Length);

//string villain = villains[randomIndex];
//Console.WriteLine($"Täna on kuritegusid sooritamas {villain}, kes küll teda peataks?!?");
//Console.WriteLine($"Juhuslikult sündmuspaika oli sattunud {hero}, kas ta suudab päästa päeva?");

//// 2 ----------
//string[] heroes = { "Benno", "Bruno", "Tilde", "Helary", "Kristina" };
//string[] villains = { "Väle kollane pall", "Pikk karvane uss", "Valge laksuv lint", "Leeki sülgav UPS Draakon", "Näksav hiireke"};

//string villain = GetRandomValueFromArray(villains);
//Console.WriteLine($"Täna on Tööstuse tänaval kuritegusid sooritamas {villain}, kes küll teda peataks?!?");
//string hero = GetRandomValueFromArray(heroes);
//Console.WriteLine($"Küll aga juhuslikult sündmuspaika oli sattunud meie kangelane {hero}, kas ta suudab päästa päeva?");

//string[] weapon = { "maitsev maius", "vildist suss", "lukustatav puur", "pangetäis vett", "pehme tekk", "potilill" };
//string heroWeapon = GetRandomValueFromArray(weapon);
//string villainWeapon = GetRandomValueFromArray(weapon);
//Console.WriteLine($"Kurjategija {villain} haaras {hero} ründamiseks - {villainWeapon}");
//Console.WriteLine($"Kangelane {hero} haarab enda kaitseks {villain} eest - {heroWeapon}");
//static string GetRandomValueFromArray(string[] someArray)
//{
//    Random rnd = new Random();
//    int randomIndex = rnd.Next(0, someArray.Length);
//    string randomStringFromArray = someArray[randomIndex];
//    return randomStringFromArray;
//}

// 3 ----------
string folderPath = @"C:\Data";
string heroFile = "kangelased.txt";
string villainFile = "pahalased.txt";

//string[] heroes = File.ReadAllLines(folderPath + heroFile); // - primitiivsem lahendus mis ka töötab aga ei sobi suurtele failidele
//string[] villains = File.ReadAllLines(folderPath + villainFile); // - primitiivsem lahendus mis ka töötab aga ei sobi suurtele failidele

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
string[] weapon = {"maitsev maius", "vildist suss", "lukustatav puur", "pangetäis vett", "pehme tekk", "potilill", "lumepall"};

string villain = GetRandomValueFromArray(villains);
int villainHP = GetCharacterHP(villain);
int villainStrikeStrength = villainHP;
Console.WriteLine($"Täna on Tööstuse tänaval kuritegusid sooritamas {villain}, kes küll teda peataks?!? Kurjategijal on {villainHP} elupunkti.");
string villainWeapon = GetRandomValueFromArray(weapon);

string hero = GetRandomValueFromArray(heroes);
int heroHP = GetCharacterHP(hero);
int heroStrikeStrength = heroHP;
Console.WriteLine($"Küll aga juhuslikult sündmuspaika oli sattunud meie kangelane {hero}, kas ta suudab päästa päeva? Kangelasel on {heroHP} elupunkti.");
string heroWeapon = GetRandomValueFromArray(weapon);

Console.WriteLine($"Kurjategija {villain} haaras {hero} ründamiseks - {villainWeapon}");
Console.WriteLine($"Kangelane {hero} haarab enda kaitseks {villain} eest - {heroWeapon}");

while (heroHP > 0 && villainHP > 0)
{
    heroHP = heroHP - Hit(villain, villainHP);
    villainHP = villainHP - Hit(hero, heroHP);
}

Console.WriteLine($"Kangelasel {hero} on järel {heroHP} elupunkti.");
Console.WriteLine($"Kurjategijal {villain} on järel {villainHP} elupunkti.");

if (heroHP > 0)
{
    Console.WriteLine($"{hero} pani kurjategija {villain} pagema, täna enam ei pea pättuste pärast muretsema!");
}
else if (villainHP  > 0)
{
    Console.WriteLine($"{villain} alistas kangelase {hero} ning läks julgel sammul edasi järgmisi kuritegusid toime panema :( ...");
}
else
{
    Console.WriteLine("Kumbki osapool ei suutnud teist poolt alistada, väsinuna langesid mõlemad sündmuspaigale teineteise kaissu magama.");
}

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

static int GetCharacterHP(string characterName)
{
    if(characterName.Length < 10)
    {
        return 10;
    }
    else
    {
        return characterName.Length;
    }
}

static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if(strike == 0)
    {
        Console.WriteLine($"{characterName} virutas mööda!");
    }
    else if(strike == characterHP - 1)
    {
        Console.WriteLine($"{characterName} virutas kõrvulukustuva hoobi, vastane kukkus oimetuks!");
    }
    else
    {
        Console.WriteLine($"{characterName} pani valuse tutaka, vastane kaotas löögi tulemusel {strike} elupunkti!");
    }
    return strike;
}