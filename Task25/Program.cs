//Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
//В задаче не использвать стандартный метод Pow!
//3, 5 -> 243 (3⁵) or 2, 4 -> 16

using static System.Console;

Write("Введите число А");
int.TryParse(ReadLine(), out int a);
Write ("Введите число B");
int.TryParse(ReadLine(), out int b);

WriteLine($"A в степени B = {Degree(a, b)}");

int Degree (int a, int b) 
	{
	int result = 1;
	for (int i = 1; i <= b; i++) 
		{
		result = a * result;
		}
	return result;
	}