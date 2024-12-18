using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:

                    int[] numbers = { 5, 12, -15, 100, 2, -45, 91, 67, -99, 13 };

                    int sum = 0;

                    // Проход по каждому элементу массива
                    foreach (int number in numbers)
                    {
                        // Проверка, является ли число двузначным
                        if ((number >= 10 && number <= 99) || (number <= -10 && number >= -99))
                        {
                            sum += number;
                        }
                    }

                    // Вывод результата
                    Console.WriteLine($"Сумма двузначных чисел в массиве: {sum}");
                    break;

                case 2:
                    double[] numbеrs = { -3.5, 2.1, -7.8, 4.6, -9.2, 5.3 };

                    // Переменная для хранения максимального по модулю значения
                    double maxAbsoluteValue = 0;

                    // Переменная для хранения элемента с максимальным по модулю значением
                    double maxElement = 0;

                    // Поиск максимального по модулю элемента
                    foreach (double number in numbеrs)
                    {
                        double absoluteValue = Math.Abs(number);
                        if (absoluteValue > maxAbsoluteValue)
                        {
                            maxAbsoluteValue = absoluteValue;
                            maxElement = number;
                        }
                    }

                    // Вывод результата
                    Console.WriteLine($"Максимальный по модулю элемент массива: {maxElement}");
                    break;

                case 3:

                    double[] temperatures = { -3.5, 2.1, -7.8, 4.6, -9.2, 5.3, -5.0, -6.0, -7.0, -8.0, -9.0, -10.0, -11.0, -12.0, -13.0, -14.0, -15.0 };

                    // Поиск индекса первого самого холодного дня
                    int coldestDayIndex = Array.IndexOf(temperatures, temperatures.Min());

                    // Вычисление суммы температур дней, предшествующих самому холодному дню
                    double summa = 0;
                    for (int i = 0; i < coldestDayIndex; i++)
                    {
                        summa += temperatures[i];
                    }

                    // Вычисление средней температуры
                    double averageTemperature = summa / coldestDayIndex;

                    // Вывод результата
                    Console.WriteLine($"Средняя температура дней, предшествующих первому самому холодному дню: {averageTemperature:F2}°C");

                    break;






























            }
Console.ReadKey();
        }
    }
}
