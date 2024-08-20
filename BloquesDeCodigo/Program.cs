//Ejercicio: Los bloques de código y el ámbito de las variables//

bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

//Ejercicio: Eliminación de bloques de código en instrucciones "if"//

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

//Desafío de ámbito de las variables//

int[] data = { 10, 20, 30, 40, 50, 60 };
int sum = 0;
bool isFound = false;

foreach (int num in data)
{
    sum += num;
    if (num == 50)
        isFound = true;
}

if (isFound)
    Console.WriteLine("Array contains 50");

Console.WriteLine($"Sum: {sum}");



