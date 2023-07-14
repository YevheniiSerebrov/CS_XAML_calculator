public class Cat
    {
        public string name = "Vasia";
        public string gender = "Male";
        private double energy;
        public readonly static double SleepEnergy = 10;
        public readonly static double MinEnergy = 0;
        public readonly static double MaxEnergy = 20;
        public readonly static double JumpEnergy = 0.5;

        public Cat()
        {
        }
        public Cat(string name, string gender, double energy): this(energy)
        {
            this.name = name;
            this.gender = gender;                      
        }

        public Cat(double energy)
        {
            this.energy = energy;
        }
        public string Name
        {
            get { return name; }
        }
        public double Energy
        {
            get { return energy; }
            set { energy = value; }
        }
        public void Jump()
        {
            energy = energy - JumpEnergy;
            if (energy < MinEnergy)
            {
                energy = MinEnergy;
                Console.Write("Я выдохся, мне надо поспать ");

            }
        
        }
        public void Sleep()
        {
            energy = energy + SleepEnergy;

        }
    }
    class Program
    {
         static void Main()
        {
            Cat cat1 = new Cat();
            Console.WriteLine("Привіт, мене звати " + cat1.name + " я " + cat1.gender);// для демонстрації роботи в методі ввести значення енергії 1
            m1: Console.WriteLine("введiть к-сть енергії");
            double Energy = double.Parse(Console.ReadLine());
            if (Energy < Cat.MinEnergy)
            {
                Console.WriteLine("Not enough energy");
                goto m1;
            }

            if (Energy > Cat.MaxEnergy) Energy = Cat.MaxEnergy;
            cat1.Energy = Energy;
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            Console.WriteLine(" Моя енергия " + cat1.Energy);
            Console.WriteLine(cat1.Energy);
            cat1.Sleep();
            Console.WriteLine("Я отдохнул Моя енергия " + cat1.Energy);
            Console.WriteLine(cat1.Energy);
            Console.ReadKey();
        }
    }
