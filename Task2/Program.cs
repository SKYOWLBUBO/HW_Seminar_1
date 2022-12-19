// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Put the first number>");
Console.WriteLine("Put the second number>");

string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if(a > b)
{
    Console.Write(a);
}

else
{
    Console.Write(b);
}