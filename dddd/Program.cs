using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddd
{
    abstract class washMashin
    {
        public abstract int Temp { get; set; }
        public abstract int Turn { get; set; }
        public abstract int Time { get; set; }    
    }
    class Regular : washMashin
    {
        
        private int temp;
        private int turn;
        private int time;

        public override int Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public override int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public override int Time
        {
            get { return time; }
            set { time = value; }
        }
        public Regular(int temp, int turn, int time)
        {
            Temp = temp;
            Turn = turn;
            Time = time;
        }
    }
    
    class Delicate : washMashin
    {
        private int temp;
        private int turn;
        private int time;
        public override int Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public override int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public override int Time
        {
            get { return time; }
            set { time = value; }
        }
        public Delicate(int temp, int turn, int time)
        {
            Temp = temp;
            Turn = turn;
            Time = time;
        }
    }

    class Inten : washMashin
    {
        private int temp;
        private int turn;
        private int time;
        public override int Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public override int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public override int Time
        {
            get { return time; }
            set { time = value; }
        }
        public Inten(int temp, int turn, int time)
        {
            Temp = temp;
            Turn = turn;
            Time = time;
        }
    }

    class Revers : washMashin
    {
        private int temp;
        private int turn;
        private int time;

        public override int Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public override int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public override int Time
        {
            get { return time; }
            set { time = value; }
        }
        public Revers(int turn, int time)
        {
            Temp = 0; 
            Turn = turn;
            Time = time; 
        }
    }
    class Display
    {
        public void ShowOp()
        {
            Console.WriteLine("1. Обычная стирка (Температура: 40°C, Обороты: 800, Время 120 минут)");
            Console.WriteLine("2. Деликатная стирка (Температура: 30°C, Обороты: 600, Время 60 минут)");
            Console.WriteLine("3. Интенсивная стирка (Температура: 60°C, Обороты: 1000, Время 30 минут)");
            Console.WriteLine("4. Режим отжима (Температура: 0°C, Обороты: 1000, Время 30 минут)");
        }
        public void ShowOpEnd(washMashin wash)
        {
            Console.WriteLine($"Текущие настройки: Температура:{wash.Temp} °C, Обороты: {wash.Turn}, Время {wash.Time} минут");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            display.ShowOp();
            washMashin washer = null;
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    washer = new Regular(40, 800, 120);
                    break;
                case 2:
                    washer = new Delicate(30, 600, 60);
                    break;
                case 3:
                    washer = new Inten(60, 1000, 30);
                    break;
                case 4:
                    washer = new Revers(1000, 30);
                    break;
                default:
                    Console.WriteLine("Введены неизвестные значения ");
                    break;
                    
            }
            display.ShowOpEnd(washer);

        }
    }
}
