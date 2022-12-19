// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число -> ");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);

int count = N * 0;
while(count < N)
{
    Console.Write(count + ",");
    count++;
    count++;
}
