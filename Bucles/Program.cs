﻿Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//Ejercicio: Realización de una actividad de desafío con instrucciones de iteración do y while//

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

//Ejercicio: Realización de una actividad de desafío para marcar la diferencia entre las instrucciones de iteración do y while//

//Proyecto 1//

string? userInput;  // Cambio de readResult a userInput
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    userInput = Console.ReadLine();
    if (userInput != null) 
    {
        valueEntered = userInput;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

userInput = Console.ReadLine();  // Uso de userInput en lugar de readResult


//Proyecto 2//

string? roleInput;  // Cambio de readResult a roleInput
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    roleInput = Console.ReadLine();
    if (roleInput != null) 
    {
        roleName = roleInput.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
roleInput = Console.ReadLine();  // Uso de roleInput en lugar de readResult


//Proyecto 3//

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;
    
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);
        
        myString = myString.Substring(periodLocation + 1);
        
        myString = myString.TrimStart();
        
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}