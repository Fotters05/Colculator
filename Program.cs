using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            Console.Write("Выберите действие (1-9):\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double sum = num1 + num2;
                    Console.WriteLine("Результат: " + sum);
                    break;
                case 2:
                    Console.Write("Введите первое число: ");
                    double nu1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double nu2 = Convert.ToDouble(Console.ReadLine());
                    double res = nu1 - nu2;
                    Console.WriteLine("Результат: " + res);
                    break;
                case 3:
                    Console.Write("Введите первое число: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    double re = n1 * n2;
                    Console.WriteLine("Результат: " + re);
                    break;
                case 4:
                    Console.Write("Введите первое число: ");
                    double nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double nume2 = Convert.ToDouble(Console.ReadLine());
                    if (nume2 != 0)
                    {
                        double resu = nume1 / nume2;
                        Console.WriteLine("Результат: " + resu);
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                    }
                    break;
                case 5:
                    Console.Write("Введите число: ");
                    double numer1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    int numer2 = Convert.ToInt32(Console.ReadLine());
                    double result = Math.Pow(numer1, numer2);
                    Console.WriteLine("Результат: " + result);
                    break;
                case 6:
                    Console.Write("Введите число: ");
                    double num11 = Convert.ToDouble(Console.ReadLine());
                    if (num11 >= 0)
                    {
                        double num22 = Math.Sqrt(num11);
                        Console.WriteLine("Результат: " + num22);
                    }
                    else
                    {
                        Console.WriteLine("Нельзя извлечь корень из отрицательного числа.");
                    }
                    break;
                case 7:
                    Console.Write("Введите число: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    double number2 = number1 / 100;
                    Console.WriteLine("Результат: " + number2);
                    break;
                case 8:
                    Console.Write("Введите число: ");
                    int numberFactorial = Convert.ToInt32(Console.ReadLine());
                    long factorial = CalculateFactorial(numberFactorial);
                    Console.WriteLine("Результат: " + factorial);
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}