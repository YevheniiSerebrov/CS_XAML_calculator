 Console.WriteLine("Кількість місяців");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оберiть тип з'єднання:");
            Console.WriteLine("1-Локальна мережа , 2-WiFi, 3-ADSL");
            int sum = 0;
            string a = Console.ReadLine();
            Console.WriteLine("Оберiть тарифний план:");
            Console.WriteLine("1-комфорт20, 2-комфорт40, 3-комфорт60");
            string b = Console.ReadLine();


            if (a == "1")
            {
                sum += 150;
            }
            if (a == "2")
            {
                sum += 100;
            }
            if (a == "3")
            {
                sum += 80;
            }


            else
            
                if (b == "1")
            {
                sum += 20;
            } 
                    
                if (b == "2")
            {
                sum += 40;
            }
                if (b == "3")
            {
                sum += 60;
            }

            
            sum *= n;

            Console.WriteLine("Сума до сплати: " + sum);
            Console.ReadLine();
///////////////////////////////////////////////
Console.WriteLine("Оберiть тип програми:");
            Console.WriteLine("1-DAO , 2-MSDE, 3-SQL");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кiлькiсть копiй");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;


            switch (a)
            {
                case 1:
                    sum += 1500;
                    break;
                case 2:
                    sum += 2250;
                    break;
                case 3:
                    sum += 2760;
                    break;
                default:
                    Console.WriteLine("Помилка при введенні даних. Введіть значення від 1 до 3!");
                    break;
            }


            if (n >= 50)
            {
                sum *= 0.6;
            }
            else 
            if (n >= 10)
            {
                sum *= 0.7;
            }
            else 
            if (n >= 5)
            {
                sum *= 0.75;
            }


            sum *= n;
            Console.WriteLine("Сума до сплати: " + sum);
            
            Console.ReadLine();
///////////////////////////////////////////////
{
            Console.WriteLine("Кількість місяців");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оберiть тип з'єднання:");
            Console.WriteLine("1-Локальна мережа , 2-WiFi, 3-ADSL");
            int sum = 0;
            string a = Console.ReadLine();
            Console.WriteLine("Оберiть тарифний план:");
            Console.WriteLine("1-комфорт20, 2-комфорт40, 3-комфорт60");
            string b = Console.ReadLine();
            if (a == "1")
            {
                sum += 150;
                if (a == "2")
                    sum += 100;
                if (a == "3")
                    sum += 80;


                else 
                if (b == "1")

                    sum += 20;
                if (b == "2")
                    sum += 40;
                if (b == "3")
                    sum += 60;
            }

            sum *= n;

            Console.WriteLine("Сума до сплати: " + sum);
///////////////////////////////////////////////

int[] arr1 = new int[5];
            
            for (int i = 0; i < arr1.Length; i++) 
            {

                Console.WriteLine($"введiть {i+1} оцiнку гравця");
                arr1[i]  = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                sum = sum + arr1[i];
                                
                    Console.WriteLine(sum);
///////////////////////////////////////////////
int i = 1;
            long lg = 1;
            Console.WriteLine("0x{0:x}", i << 1);
            Console.WriteLine("0x{0:x}", i << 63);
            Console.WriteLine("0x{0:x}", lg << 12);
///////////////////////////////////////////////
int n = 17, m = 3, p, q;
            p = n >> 2;//ділить на 2 і 2
            q = m << 2;//
            Console.WriteLine("p=" +p);
            Console.WriteLine("q=" + q);
///////////////////////////////////////////////
long x = -75, y = -333, u, v, w;
            u = x >> 3;
            v = y << 2;
            w = x / 4;
            Console.WriteLine("u=" + u);
            Console.WriteLine("v=" + v);
            Console.WriteLine("w=" + w);


///////////////////////////////////////////////

//задача про гравців
int[] a = new int[5];
            int sum = 0;
            Console.WriteLine("Введіть бали 1-го гравця ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }

            int sum1 = 0;
            Console.WriteLine("Введіть бали 2-го гравця ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum1 = sum1 + a[i];
            }
            Console.WriteLine("сума балів 1-го гравця = : " + sum);
            Console.WriteLine("сума балів 2-го гравця = : " + sum1);

            Console.ReadLine();
///////////////////////////////////////////////

//5.91
double sum = 1;
            int f = 1;
            Console.WriteLine("введіть число n");
            	int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("введіть число x");
            	int x = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
                sum += (Math.Pow(x,i))/(f);         
            }

            Console.WriteLine(sum);
            Console.ReadKey();
///////////////////////////////////////////////

Console.WriteLine("Випадковим чином виведено масив з 30 елементів");
            
            int[] a = new int[30];
            Random k = new Random();
            for (int i = 0; i < 30; i++) { 
                a[i] = k.Next(0, 30);
                Console.WriteLine(a[i]);
            }

            for (int i = a.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (a[j] > a[j + 1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
            int count = 1;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < a[i + 1]) count++;
            }
            Console.WriteLine("Всього різних чисел " + count);
            Console.ReadKey();
///////////////////////////////////////////////
for (int i = 1; i < 300; i++)
            {
                int b = 0;
                int count = 0;
                for (int a = 1; a < 300; a++)
                {
                    
                    if (i % a == 0)
                    {
                         b = count++;                        
                    }

                    
                }
                if (b == 5) Console.Write(i + " ");
            }

            Console.ReadKey();
///////////////////////////////////////////////
int[] a = new int[8];
            int[] b = new int[8];
            Random k = new Random();
            
            int sum2 = 0;
            int sum = 0;
            Console.WriteLine("Ціни товарів колекції А");
            for (int i = 0; i < 8; i++)
            {
                
                a[i] = k.Next(10, 100);

                Console.WriteLine(a[i]);
                sum = sum + a[i];
            }
            Random l = new Random();
            Console.WriteLine("Ціни товарів колекції Б");
            for (int j = 0; j <  8; j++)
            {
                
                b[j] = l.Next(0, 15);
                Console.WriteLine(b[j]);
                sum2 = sum2 + b[j];
            }
            if (sum > sum2) Console.WriteLine("Колекція Б дешевша");
            else Console.WriteLine("Колекція А дешевша");

            Console.ReadLine();
///////////////////////////////////////////////
int[] a = new int[5];
            int max = 0;
            double diagonal = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the area of the square # " + (i + 1) + "\t");
                a[i] = Convert.ToInt16(Console.ReadLine());
                if (a[i] > max)
                {
                    max = a[i];
                }
                
            }
            diagonal = Math.Sqrt(2)*max;
            Console.WriteLine("max sq = ");
            Console.WriteLine(max);
            Console.WriteLine("diagonal = ");
            Console.WriteLine(diagonal);
            Console.ReadLine();
        }
///////////////////////////////////////////////
int c = 0;
            int count = 0;
            int[] t = new int[30];
            Random k = new Random();
            for (int i = 0; i < 30; i++)
            {
                t[i] = k.Next(-10, 10);
                Console.WriteLine(t[i]);
                if (t[i] < 0)
                {
                    ++count;
                    c = +count;
                }

            }
            Console.WriteLine("the temperature was below 0 ");
            Console.WriteLine(c + " times");
            Console.ReadKey();
///////////////////////////////////////////////
Console.Write("Введіть число :");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int M = num;
            Console.Write("Скільки останніх чисел будемо сумувати : ");
            int N = int.Parse(Console.ReadLine());
            if (N < M)
            {
                sum = 0;

                for (int i = 0; i < N; i++)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                Console.WriteLine("Сумма {0} останніх чисел числа {1} дорівнює {2}", N, M, sum);
            }
            
            Console.ReadLine();
///////////////////////////////////////////////
int[] a = new int[20];
            Random k = new Random();
            for (int i = 1; i < 20; i++)
            {
                a[i] = k.Next(0, 100);
                Console.WriteLine(a[i] + "\t");
                
                if (a[i] % 10 == 7) Console.WriteLine("Iндекс елемента, що закiнчується на 7: " + i);
            }
            Console.ReadKey();
///////////////////////////////////////////////
int n, max = 0;
            Console.WriteLine("Введите число");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                if (max < n % 10) max = n % 10;
                n /= 10;
            }
            Console.WriteLine(max);
            Console.ReadKey();
/////////////////////classes//////////////////////////
  class Goods
    {
        public string NameTov;
        public string data;
        public double cina;
        public int col;
        public int nomnakl;
        public string st;//для збереження назви товару
        public Goods()
        {
            
        }
        public string svtov(string NameTov, string data, double cina, int col, int nomnakl)
        {
            return st = "Товар " + NameTov + " реалізований " + data + " за ціною " + cina + " в кількості " + col + ", номер накладної " + nomnakl;
        }

        public void set(int col, double cina, string NameTov)
        {
            this.col = col;
            this.cina = cina;
            this.NameTov = NameTov;
            
            
        }
        
        public double stoim(int col, double cina)
        {
            Console.WriteLine("Вартість");
            return (col * cina);
        }
        public double izmcina()
        {
            Console.WriteLine("ВВедіть ціну");
            return cina = Double.Parse(Console.ReadLine());
        }
        public int izmcol()
        {
            Console.WriteLine("ВВедіть кількість товару");
                return col = int.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Goods t1 = new Goods();
            Console.Write("ВВедіть назву товару: " );
            t1.NameTov = Console.ReadLine();
            Console.Write("Введіть номер накладної: ");
            t1.nomnakl = int.Parse(Console.ReadLine());
            Console.Write("Введіть дату: ");
            t1.data = Console.ReadLine();
            t1.cina = t1.izmcina();
            t1.col = t1.izmcol();
            int col = t1.col;
            double cina = t1.cina;
            Console.WriteLine("Вартість товару {0} ", t1.stoim(col, cina));
            Console.WriteLine(t1.svtov(t1.NameTov, t1.data, cina, col, t1.nomnakl));
            Console.ReadKey();
        }
    }
  /////////////////////////////////////////////////
   Console.WriteLine("введіть рядок");
            StringBuilder a = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < a.Length; ++i)
                if (i % 2 != 0 && a[i] == ' ') { a[i] = ' '; ++i; }
                else if (i % 2 != 0) { a[i] = 'ы'; ++i; }

            Console.WriteLine("Змінений рядок: " + a);

            Console.ReadKey();
/////////////////////////////////////////////////
char k = ' ';
            int kp = 0;
            Console.WriteLine("Введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());



            for (int i = 0; i < a.Length; ++i)
            {
                k = a[i];
                if (k == ' ') kp++;
            }
            Console.WriteLine("кiлькiсть пробiлiв в реченнi: " + kp);
            Console.ReadKey();
/////////////////////////////////////////////////
string str1, str2, str3, str4;
            string a, b, c, d;
            str1 = "трос";
            str2 = "";
            str3 = "";
            str4 = "";
            a = str1.Substring(0,1);
            b = str1.Substring(1,1);
            c = str1.Substring(2,1);
            d = str1.Substring(3,1);
            str2 = string.Concat(a, c, b, d);
            str3 = string.Concat(d, c, b, a);
            str4 = string.Concat(b, c, d, a);
            Console.WriteLine(str1 + " " + str2 + " " + str3 + " " + str4);
            Console.ReadKey();
/////////////////////////////////////////////////

string str1, str2, str3, str4;
            string a, b, c, d;
            str1 = "трос";
            str2 = "";
            str3 = "";
            str4 = "";
            a = str1.Substring(0, 1);
            b = str1.Substring(1, 1);
            c = str1.Substring(2, 1);
            d = str1.Substring(3, 1);
            char[] b1 = str1.ToCharArray();
            str2 = string.Concat(b1[0], b1[2], b1[1], b1[3]);
            str3 = string.Concat(b1[3], b1[2], b1[1], b1[0]);
            str4 = string.Concat(b1[1], b1[2], b1[3], b1[0]);
            Console.WriteLine(str1 + " " + str2 + " " + str3 + " " + str4);
            Console.ReadKey();
/////////////////////////////////////////////////
string str1 = "прроцесор";
            int v = str1.IndexOf("р");
            str1 = str1.Remove(v, 1);
            Console.WriteLine(str1);
            int b = str1.IndexOf("с");
            str1 = str1.Insert(b+1,"с");
            Console.WriteLine(str1);
            //текст.файл

            Console.ReadKey();
/////////////////////////////////////////////////
string str1 = "теекстовыйфайл";
            int v = str1.IndexOf("е");
            str1 = str1.Remove(v, 1);
            
            int b = str1.IndexOf("й");
            str1 = str1.Insert(b+1," ");
            Console.WriteLine(str1);
            //текст.файл

            Console.ReadKey();
/////////////////////////////////////////////////
string str1 = "програма и аллгоритм";
            int v = str1.IndexOf("м");
            str1 = str1.Insert(v+1, "м");
            
            int b = str1.IndexOf("л");
            str1 = str1.Remove(b,1);
            Console.WriteLine(str1);
            //текст.файл
string str1 = "процесор и паммять";
            int v = str1.IndexOf("с");
            str1 = str1.Insert(v+1, "с");
            
            int b = str1.IndexOf("м");
            str1 = str1.Remove(b,1);
            Console.WriteLine(str1);
            //текст.файл

            Console.ReadKey();
/////////////////////////////////////////////////
 Console.WriteLine("введіть перше слово");
            string str1 = Console.ReadLine();
            Console.WriteLine("введіть друге слово");
            string str2 = Console.ReadLine();
            char[] a1 = str1.ToCharArray();
            //char[] b1 = str2.ToCharArray();
            string res = "";
            char ps;
            int v = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                ps = a1[i];
                v = str2.IndexOf(ps);
                if (v >= 0)
                {
                    res = res + "да ";

                }
                else
                {
                    res = res + "нет ";
                }
            }
            Console.WriteLine(res);
            Console.ReadKey();
            Console.ReadKey();
/////////////////////////////////////////////////
static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.Write("c = ");
            int c = Convert.ToInt16(Console.ReadLine());
            double res = Prikl(a, b, c);
            Console.WriteLine("res = " + res);
            Console.ReadKey();

        }
        static double Prikl(int a, int b, int c)
        {
            double x = ((Math.Sqrt(a) + Math.Sqrt(b) + Math.Sqrt(c) + (a + b + c)) / 2);
            return x;

        }
/////////////////////////////////////////////////
static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt16(Console.ReadLine());

            double x = Maximum(a, b);
            Console.Write("x = " + x);

            Console.ReadKey();

        }
        static double Maximum(int a, int b)
        {
            int max1, max2 = 0;
            if (a > 2 * b) max1 = a;
            else max1 = 2 * b;
            if ((2 * a - b) > b) max2 = 2 * a - b;
            else max2 = b;

            double x = max1 * max2;
            return x;

        }
/////////////////////////////////////////////////
static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt16(Console.ReadLine());

            double x = Maximum(a, b);
            Console.Write("x = " + x);

            Console.ReadKey();

        }
        static double Maximum(int a, int b)
        {            
             double x = Math.Max(a, 2 * b) * Math.Max(2 * a - b, b);
                       return x;
        }
/////////////////////////////////////////////////
 static void line()
        {
            int k = 0;
            while (k < 80)
            {
                Console.Write("*");
                k++;
            }
        }

        static void Main(string[] args)
        {
            line();
            Console.ReadLine();


        }
/////////////////////////////////////////////////
static void line()
        {
            int j = 0;
            int i = 0;
            int k = 0;
            while (k < 5)
            {
                Console.Write(" o o");


               ++k;
            }
            Console.WriteLine("");
            while (j < 9)
            {
                Console.WriteLine("o                  o");


                j++;
            }
            while (i < 5)
            {
                Console.Write(" o o");


                i++;
            }
        }

        static void Main(string[] args)
        {
            line();
            Console.ReadLine();


        }
