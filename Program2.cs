Console.WriteLine("Welcome to LIMAN RPG! Are you ready to create your charater? Type 1 for yes or 0 for no");
int answer1 = int.Parse(Console.ReadLine());
if ( answer1 == 0)
{
    Console.WriteLine("Come back when you're ready for an adventure!");

}
else if ( answer1 == 1)
{
    Console.WriteLine("What will be the name of your character?");
} else
{
     Console.WriteLine("stupid");
}

String characterName = (Console.ReadLine());

Console.WriteLine("What class will you choose?( type 1, 2 or 3)");
Console.WriteLine("ROGUE KNIGHT\nHOODWINK\nVENOMANCER");

int answer2 = int.Parse(Console.ReadLine());

Console.WriteLine("What is you current health?" );
int health = int.Parse(Console.ReadLine());

Console.WriteLine("What is you current attack damage?" );
int attackDamage = int.Parse(Console.ReadLine());
int totalPower = attackDamage + health;

if( answer2 == 1)
{
    Console.WriteLine("+================================+" );
    Console.WriteLine("\t"+ characterName +" The Rogue Knight " );
    Console.WriteLine("Abilities:\n+Storm Hammer+\n+Great Cleave+\n+War Cry+\n+God's Strength+" );
    Console.WriteLine("+Current health: " + health +"+" );
    Console.WriteLine("+Current attack damage: " + attackDamage + "+");
    Console.WriteLine("+Total power: " + totalPower + "+" );
    Console.WriteLine("+Good luck on your adventure, " + characterName +"!+");
    Console.WriteLine("+================================+" );
    

} else if(answer2 == 2)
{
    Console.WriteLine("+================================+" );
    Console.WriteLine("\t"+ characterName +" The Hoodwink " );
    Console.WriteLine("Abilities:\n+Acorn Shot+\n+Bushwack+\n+Scurry+\n+Sharpshooter+" );
    Console.WriteLine("+Current health: " + health +"+" );
    Console.WriteLine("+Current attack damage: " + attackDamage + "+");
    Console.WriteLine("+Total power: " + totalPower + "+" );
    Console.WriteLine("+Good luck on your adventure, " + characterName +"!+");
    Console.WriteLine("+================================+" );
} else if (answer2 == 3)
{
    Console.WriteLine("+================================+" );
    Console.WriteLine("\t"+ characterName +" The Venomancer " );
    Console.WriteLine("Abilities:\n+Venomous Gale+\n+Poison Sting+\n+Plague Ward+\n+Noxious Plague+" );
    Console.WriteLine("+Current health: " + health +"+" );
    Console.WriteLine("+Current attack damage: " + attackDamage + "+");
    Console.WriteLine("+Total power: " + totalPower + "+" );
    Console.WriteLine("+Good luck on your adventure, " + characterName +"!+");
    Console.WriteLine("+================================+" );
}