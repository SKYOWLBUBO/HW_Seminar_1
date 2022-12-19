// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
Console.WriteLine("Введите третье число");

string num1 = Console.ReadLine();
int a = Convert.ToInt32(num1);

string num2 = Console.ReadLine();
int b = Convert.ToInt32(num2);

string num3 = Console.ReadLine();
int c = Convert.ToInt32(num3);



int[] numbers = {a,b,c};
int i = 0;
int max = numbers[i];
while(i < numbers.Length)
{
    if(max < numbers[i])
    {
        max = numbers[i];
    }
   i++;       // index = index + 1 
}

Console.WriteLine(max);


