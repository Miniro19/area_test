using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, p, c, Rad;
            int variant;
            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Трапеция"); // добавили фигурку
            Console.WriteLine("4. Треугольник"); //добавила треугольник
            //Console.WriteLine("5. Сектор");

            string temp = Console.ReadLine();

            try
            {
                 variant = Convert.ToInt32(temp);    // преобразование в число
            }
            catch { variant = 0; }

            try
            {

                switch (variant)
                {
                    case 1:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь прямоугольника = " + a * b);
                        break;

                    case 2:
                        Console.Write("Радиус R = ");
                        temp = Console.ReadLine();
                        Rad = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь круга = " + Math.PI * Math.Pow(Rad, 2));
                        break;

                   

                    case 3:
                        Console.Write("Основание А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Основание B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.Write("Высота H = ");
                        temp = Console.ReadLine();
                        h = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь трапеции = " + (a + b) * h / 2);
                        break;

                    case 4:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.Write("Сторона С = ");
                        temp = Console.ReadLine();
                        c = Convert.ToDouble(temp);
                        p = (a + b + c) / 2;
                        Console.WriteLine("Площадь треугольника = " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                        break;
            default: Console.WriteLine("Выбор неверен "); break;
                }
            }

            catch { Console.WriteLine("Ошибка при вводе числа"); }

        } 
    }
}

