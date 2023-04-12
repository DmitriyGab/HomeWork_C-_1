// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2 = Convert.ToInt32 (Console.ReadLine());

// if (number1 > number2)
// {
//     Console.Write(number1);
//     Console.WriteLine(" - Max Number");
//     Console.Write(number2);
//     Console.WriteLine(" - Min Number");
// }

// else
// {
//     Console.Write(number2);
//     Console.WriteLine(" - Max Number");
//     Console.Write(number1);
//     Console.WriteLine(" - Min Number");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число 3");
int number3 = Convert.ToInt32 (Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
    Console.Write(number1);
    Console.WriteLine(" - большее число");
    }
    
    else
    {
    Console.Write(number3);
    Console.WriteLine(" - большее число");
    }
}

else if (number2 > number3)
{
    Console.Write(number2);
    Console.WriteLine(" - большее число");
}

else if (number2 < number3)
{
    Console.Write(number3);
    Console.WriteLine(" - большее число");
}

else
{
        Console.WriteLine("Числа равны");
}


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int NegNumber = number % 2;

// if (NegNumber == 0)
// {
//         Console.WriteLine(number);
//         Console.WriteLine(" - четное число");
// }
// else
// {
//         Console.WriteLine(number);
//         Console.WriteLine(" - нечетное число");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int current_number = 0;

// while (current_number <= number)
// {
//     current_number++;
//     int NegNumber = current_number % 2;
//     if (NegNumber == 0);
//     {
//         Console.WriteLine(current_number);
//     }
    
//     else
//     {
//         Console.WriteLine(" ");
//     }
// }

