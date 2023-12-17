using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            //Random rnd = new Random();
            //int number = rnd.Next(10, 99);
            //Console.WriteLine($"number={ number}");
            //string stroka = (number % 2 == 0) ? "четное число" : "Нечетное число ";
            //Console.WriteLine($"{stroka}");
            //Console.ReadKey();

            //Задача 2.Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            //Random rnd = new Random();
            //int number = rnd.Next(1, 7);
            //Console.WriteLine($"number={ number}");
            //switch (number)
            //{
            //case 1:Console.WriteLine("Понедельник");break;
            //case 2:Console.WriteLine("Вторник");break;
            //case 3:Console.WriteLine("Среда");break;
            //case 4:Console.WriteLine("Четверг");break;
            //case 5:Console.WriteLine("Пятница"); break;
            //case 6:Console.WriteLine("Суббота"); break;
            //case 7:Console.WriteLine("Воскресенье"); break;
            //Console.ReadKey();
            //}

            //Задача 3.Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.
            //Console.WriteLine("Введите 1 число");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите 2 число");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите 3 число");
            //int c = int.Parse(Console.ReadLine());
            //if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            //{
            //    a /= 2;
            //    b /= 2;
            //    c /= 2;
            //}
            //else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            //{
            //    a *= 2;
            //    b *= 2;
            //    c *= 2;
            //}
            //else
            //{
            //    a += 1;
            //    b += 1;
            //    c += 1;

            //}
            //Console.WriteLine($"Результат: {a}, {b}, {c}");
            //Console.ReadKey();

            //Задача 4.Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».
            //Console.WriteLine("Введите балл учащегося:");
            //int point = int.Parse(Console.ReadLine());
            //if (point >= 0 & point < 50)
            //{
            //    Console.WriteLine("Неудовлетворительно");
            //}
            //if (point >= 50 & point < 69)
            //{
            //    Console.WriteLine("Удовлетворительно.");
            //}
            //    if (point >= 70 & point < 89)
            //    {
            //        Console.WriteLine("Хорошо");
            //    }
            //    if (point >= 90 & point < 100)
            //    {
            //        Console.WriteLine("Отлично");
            //    }           
            //Console.ReadKey();

            //Задача 5.Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник.Вывести на экран периметр и площадь заданной фигуры(данные, необходимые для расчетов, запросить у пользователя).
            //Console.WriteLine("Введите признак геометрической фигуры (к - круг, п - прямоугольник, т - треугольник): ");
            //char st = char.Parse(Console.ReadLine());
            //switch (st)
            //{
            //    case 'к':
            //        Console.WriteLine("Введите радиус круга:");
            //        double radius = Convert.ToDouble(Console.ReadLine());
            //        double circleArea = Math.PI * Math.Pow(radius, 2);
            //        double circlePerimeter = 2 * Math.PI * radius;
            //        Console.WriteLine($"Площадь круга: {circleArea}, Периметр круга: {circlePerimeter}");
            //        break;
            //    case 'п':
            //        Console.WriteLine("Введите длину прямоугольника:");
            //        double length = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите ширину прямоугольника:");
            //        double width = Convert.ToDouble(Console.ReadLine());
            //        double rectangleArea = length * width;
            //        double rectanglePerimeter = 2 * (length + width);
            //        Console.WriteLine($"Площадь прямоугольника: {rectangleArea}, Периметр прямоугольника: {rectanglePerimeter}");
            //        break;
            //    case 'т':
            //        Console.WriteLine("Введите длину первой стороны треугольника:");
            //        double side1 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите длину второй стороны треугольника:");
            //        double side2 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Введите длину третьей стороны треугольника:");
            //        double side3 = Convert.ToDouble(Console.ReadLine());
            //        double Perimeter = side1 + side2 + side3;
            //        double perimeter = Perimeter / 2;
            //        double Area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            //        Console.WriteLine($"Площадь треугольника: {Area}, Периметр треугольника: {Perimeter}");
            //        break;
            //    default:
            //        Console.WriteLine("Неверный ввод. Пожалуйста, введите 'к' для круга, 'п' для прямоугольника или 'т' для треугольника.");
            //        break;
            //}
            //Console.ReadKey();

            //Задача 6.Написать приложение, которое позволяет вычислить сумму страхового взноса(SV) для автомобиля. Входные данные будут вводиться с клавиатуры:
            //Console.WriteLine("Введите марку автомобиля:");
            //string MA = Console.ReadLine();
            //Console.WriteLine("Введите срок страхования (от 1 до 12 месяцев):");
            //int months = int.Parse(Console.ReadLine());
            //if (months < 1 || months > 12)
            //{
            //    Console.WriteLine("Некорректный срок страхования. Введите значение от 1 до 12 месяцев.");
            //    return;
            //}
            //double percentIncrease;
            //if (months < 3)
            //    percentIncrease = 10;
            //else if (months < 6)
            //    percentIncrease = 8;
            //else
            //    percentIncrease = 5;
            //double baseInsuranceCost = 50;
            //double insuranceSum = baseInsuranceCost * months * (1 + percentIncrease / 100);
            //Console.WriteLine($"Ваш автомобиль марки {MA} был застрахован.");
            //Console.WriteLine($"Сумма страхового взноса составила {insuranceSum} руб.");
            //Console.ReadKey();
        }
    }
}
