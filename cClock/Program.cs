using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cClock
{
    class Program
    {
        static void Main(string[] args)
        {
            //debug console (first check if its correctly startups
            Console.WriteLine("Iam doing something!");

            //the NOT analogue clock heheh
            AnaClock clock;
            clock = new AnaClock();
            Console.WriteLine(clock.Time());

            //Just to keep console open till I want it closed ;)
            Console.ReadKey();
        }
    }

    class AnaClock
    {
        public AnaClock()
        {
            this.time = GetTime;
        }
        
        private string time;
        public string GetTime
        {
            get { return DateTime.Now.ToLongTimeString(); }
            set { time = value; }
        }

        public string Time()
        {
            return GetTime;
        }
    }
}
