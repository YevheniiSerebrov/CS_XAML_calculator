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
