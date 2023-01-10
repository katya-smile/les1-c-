// Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Большое число:" +num1+  "Меньшее число:" +num2+"");
}
else if (num2 > num1)
{
    Console.Write("Большое число:" +num2+  "Меньшее число:" +num1+"");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
// из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num1 > max ) max = num1; 
if (num2 > max ) max = num2;  
if (num3 > max ) max = num3;  

Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
   Console.WriteLine("нет"); 
}
else 
{
    Console.WriteLine("да");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

while(i <= num)
    {
        if(i % 2 == 0)
        Console.Write(i + ", ");
        i ++;
    }
