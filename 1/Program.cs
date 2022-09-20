// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N по убыванию.

// M = 1; N = 5. -> ""5,4,3,2,1""
// M = 4; N = 8. -> ""8,7,6,5,4""

using static System.Console;
Clear();

WriteLine("Введите число M");
int numberM = int.Parse(ReadLine()!);
WriteLine("Введите число N");
int numberN = int.Parse(ReadLine()!);
WriteLine(Stringnumbers(numberM, numberN));



string Stringnumbers(int num1, int num2)
{
    if (num1 == num2) return $"{num1}";
    else if (num1 > num2) return $"{num1} {Stringnumbers(num2, num1 - 1)}";
    else return $"{num2} {Stringnumbers(num1, num2 - 1)}";

}