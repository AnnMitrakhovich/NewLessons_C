// МАССИВЫ и ФУНКЦИИ:
// Вывести число из отрезка от 10 до 99, найти наибольшую цифру этого числа
// // если 54/10 = 5; 54%10=4. Так получим цифры числа. Сравним их.

// int RandomNum()
// {
//     int num = new Random().Next(10, 100);
//     Console.WriteLine($"Сгенерированное число: {num}");
//     return num;
// } 

// int MaxDigit (int number) 
// {
//     int first = number / 10;
//     int second = number % 10;
//     if (first > second)
//     {
//         return first;
//     }
//     else return second;
// }
// int rand = RandomNum();
// int maxDigit = MaxDigit(rand);
// Console.WriteLine($"Максимальная цифра в числе {rand} = {maxDigit}");

// Console.Clear();
// void FillArray(int[] collection)
// {
// 	int lenght = collection.Length;
// 	int index = 0;
// 	while (index < lenght)
// 	{
// 		collection[index] = new Random().Next(1, 10); // случайное число от 1 до 10
// 		index++;
// 	}
// }

// void PrintArray(int[] col)
// {
// 	int count = col.Length;
// 	int position = 0;
// 		while (position < count)
// 		{
// 			System.Console.WriteLine(col[position]);
// 			position++;
// 		}
// }

// 	int IndexOf(int[] collection, int find)
// 	{
// 		int count = collection.Length;
// 		int index = 0;
// 		int position = -1;
// 		while(index < count)
// 		{
// 			if(collection[index] == find)
// 			{
// 					position = index;
// 					break;
// 			}
// 			index++;
// 		}
// 		return position;
// 	}


// int[] array = new int[10];

// FillArray(array);
// array[4]=4;
// array[6]=4;
// PrintArray(array);
// System.Console.WriteLine();

// int pos = IndexOf(array, 4);
// System.Console.WriteLine(pos);
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// int RandomNum()
// {
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine($"Сгенерировалось число: {num}");
//     return num;
// }

// int DelSecondDigit(int num)
// {
//     int first = num / 100;
//     int second = num % 10;
//     int twoDigits = first * 10 + second;
//     return twoDigits;
// }

// int number = RandomNum();
// int result = DelSecondDigit(number);
// Console.WriteLine($"Получилось: {result}");

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// int FindResult(int number1, int number2)
// {
//     result = number1 % number2;
//     return result;
// }

// int res = FindResult(number1, number2);
// if (res == 0)
// {
//     Console.WriteLine("Первое число кратно второму");
// } 
// else 
// {
//     Console.WriteLine($"Первое число некратно второму. Остаток {res}");
// }
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
// int InputNum (string message)
// {
//     Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine()!);
//     return number;
// }
// string Multiplicity (int num)
// {
//     string result = "Нет";
//     if (num % 7 == 0 && num % 23 == 0)
//             result = "Да";
//         return result;
// }
// int number1 = InputNum("Введите число: ");
// string answer = Multiplicity(number1);
// Console.WriteLine(answer);

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int InputNumber (string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine()!);
    return number;
}
int FindSecondDigit(int num)
{
    int tennum = num / 10;
    int secondnum = tennum % 10;
    return secondnum;
}
int number1 = InputNumber("Введите трехзначное число: ");
int second = FindSecondDigit(number1);
Console.WriteLine($"Для трехзначного числа {number1} вторая цифра равна {second}.");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет




