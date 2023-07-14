using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Figure
    {
        public double y;
        public double x;
        public double a = 1;
        public double b = 4;
        public double c = 8;
    }
    class Line:Figure
    {     
        public void Show1() {y = a + b * x; Console.WriteLine(y);}
    }
    class Cube:Figure
    {        
        public void Show2()
        { y = a * Math.Pow(x,2) + b * x + c;  Console.WriteLine(y); }
    }
    class Hyper:Figure
    {
        public void Show3()
        { y = a/x + b*x +c; Console.WriteLine(y); }
    }
    class Program
    {
        static void Main()
        {
            Figure f = new Figure();
            int g;
            Console.WriteLine("Введи вид функції: 1) лінійна, 2) кубічна, 3) гіперболічна");
            g = int.Parse(Console.ReadLine());
            if (g == 1)
            {
                Line l = new Line();
                //Console.WriteLine("Введи параметри а функції: y = a + b * x");
                //l.a = int.Parse(Console.ReadLine());
                //Console.WriteLine("Введи параметри b функції: y = a + b * x");
                //l.b = int.Parse(Console.ReadLine());                
                Console.WriteLine("Введи параметри x функції: y = a + bx");
                l.x = int.Parse(Console.ReadLine());
                l.Show1();

            }
            if (g == 2)
            {
                Cube k = new Cube();
                //Console.WriteLine("Введи параметри а функції: y = a * x^2 + b * x + c");
                //k.a = int.Parse(Console.ReadLine());
                //Console.WriteLine("Введи параметри b функції: y = a * x^2 + b * x + c");
                //k.b = int.Parse(Console.ReadLine());
                //Console.WriteLine("Введи параметри c функції: y = a * x^2 + b * x + c");
                //k.c = int.Parse(Console.ReadLine());
                Console.WriteLine("Введи параметри x функції: y = ax^2 + bx + c");
                k.x = int.Parse(Console.ReadLine());
                k.Show2();
                
            }
            if (g == 3)
            {
                Hyper h = new Hyper();
                //Console.WriteLine("Введи параметри а функції: y = a/x + bx + c");
                //k.a = int.Parse(Console.ReadLine());
                //Console.WriteLine("Введи параметри b функції: y = a/x + bx + c");
                //k.b = int.Parse(Console.ReadLine());
                //Console.WriteLine("Введи параметри c функції: y = a/x + bx + c");
                //k.c = int.Parse(Console.ReadLine());
                Console.WriteLine("Введи параметри x функції: y = a/x + bx + c");
                h.x = int.Parse(Console.ReadLine());
                h.Show3();

            }


            Console.ReadKey();
        }
    }
    class Circle
    {
        public int x = 0;
        public int y = 0;
        public int R = 3;
        public const double P = 3.14;
        public static string name = "Коло ";
        double p;
        double s;
    }
    class Program
    {
        
       
        static void Main(string[] args)
        {
            Circle cr = new Circle();
            Console.WriteLine("P = " + Circle.P);
            Console.Write(Circle.name);//доступ лиш до статік і конст
            Console.WriteLine(" с центром в точке ({0},{1}) и радиусом {2}", cr.x, cr.y, cr.R);//через об'єкт або екзмепляр
            //Console.WriteLine(cr.p); 
            Console.Write("Введите коэффициент = ");
            int kof = int.Parse(Console.ReadLine());
            cr.x -= kof; cr.y += kof; cr.R *= kof;
            Console.WriteLine(" Новая окружность с центром в точке ({0},{1}) и радиусом {2}", cr.x, cr.y, cr.R);
            //cr.s = 2  * Circle.P  * cr.R;
            Console.ReadKey();
        }
    class DemoPoint
    {
        protected int x;
        protected int y;
        public void Show()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
        public DemoPoint(int x, int y)
        {
            this.x = x; 
this.y = y;
        }
        public DemoPoint()
        {
            this.x = 1; this.y = 1;
        }
        

    }
    class DemoLine:DemoPoint
    {
        public int xend;
        public int yend;
        new public void Show()
        {
            x = 2;
            y = 2;

            Console.WriteLine("({0}, {1})-({2}, {3})", x, y, xend, yend);
        }

        public DemoLine(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            xend = x2; yend = y2;
        }
        public DemoLine()
        {
            xend = 100; yend = 100;
        }
        public DemoLine(int x2, int y2)
        {
            xend = x2; yend = y2;
        }

    }
        class Aqua{
            static void aq(){
                Console.WriteLine("Скільки годин ви перебували в аквапарку? (1-15)");
            int h = Convert.ToInt16(Console.ReadLine());           
            Console.WriteLine("Година вашого прибуття:");
            Double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Чи відвідували ви сауну? 1) Так, 2) Ні");
            byte sauna = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Чи є у вас картка на знижку? 1) Так, Silver;  2) Gold; 3) VIP; 4) Немає ніякої.");
            byte card = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Наявність браслету 1) Так, віддав(ла) його охоронцю; 2)Я загубив(ла) його в парку");
            byte br = Convert.ToByte(Console.ReadLine());
            double sum = 0;
            Double a = t + h;
            if (t >= 7 && t < 10 && a >= 16 )
            {
                sum = sum + 40*a - 30*t - 220;
            }
            if (t >= 7 && t < 10 && a >=10 && a < 16 )
                {
                    sum = sum + 20*h - 10*t +100;
                }
                if (t >= 7 && t < 10 &&  a < 10)
                {
                    sum = sum + 30*h;
                }
                
                    if (t >= 10 && t < 16 && a < 16)
                    {
                        sum = sum + 20 * h;
                    }
                    if (t >= 10 && t < 16 && a >= 16)
                    {
                        sum = sum + 40*h +20*t -320;
                    }

                        if (t>=16 && t<=22)
                        {
                            sum = sum + h*40;
                        }
                        else 
                if (sauna == 1)
                {
                sum += 50;
                }
            switch (card)
            {
                case 1:
                    sum *= 0.85;
                    break;
                case 2:
                    sum *= 0.8;
                    break;
                case 3:
                    sum *= 0.6;
                    break;
                case 4:
                    sum *= 1;
                    break;
            }
            if (br == 1)
            {
                sum = sum + 0;
            }
            else
                if (br == 2)
                {
                sum += 500;
            }
            if (h>15 || h < 1 || card > 4 || t < 1 || sauna > 2 || t > 22)
            {
                sum = sum * 0;
                Console.WriteLine("Здійснено помилку при введенні даних " );
            }
                Console.WriteLine("Сума до сплати: " + sum);
            Console.ReadKey();
            }
        }
    class Program
    {
        static void Main()
        {
            DemoPoint point1 = new DemoPoint();
            DemoPoint point2 = new DemoPoint(5, 5);
            point1.Show();
            point2.Show();
            DemoLine line1 = new DemoLine();
            DemoLine line2 = new DemoLine(4, 4);
            DemoLine line3 = new DemoLine(2, 2, 10, 10);
            line1.Show();
            line2.Show();
            line3.Show();
            Console.ReadKey();
        }
    }
    }

}
