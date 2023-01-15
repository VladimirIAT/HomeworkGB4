// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;

Write("Введите число ");
int.TryParse(ReadLine(), out int a);

WriteLine($"Сумма цифр в числе = {Sum(a)}");

int Sum (int b) 
	{
	int result = 0;
	int c = 0;
	while (b > 1) 
		{
		c = b%10;
		b = b/10;
		result = c + result;
		}
	return result;
	}