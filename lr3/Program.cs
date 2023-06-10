using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b ,h, Rad; // объявили высоту
            int variant;
            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Трапеция"); // добавили фигурку
            //Console.WriteLine("4. Треугольник");
       
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

                    default: Console.WriteLine("Выбор неверен "); break;

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

                }
            }

            catch { Console.WriteLine("Ошибка при вводе числа"); }

        } 
    }
}

