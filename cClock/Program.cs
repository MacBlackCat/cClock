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
            //the NOT analogue clock heheh
            AnaClock clock = new AnaClock();

            while (true)
            {
                clock.SetTime();
                Console.Write(clock.Time);


                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    class AnaClock
    {
        // public accessable string with the last set time
        public string Time { get; set; }
        private int _width;
        private int _heigth;

        //Function to set the current time in the above string
        public void SetTime()
        {
            this.Time = DateTime.Now.ToLongTimeString();
        }

        public 
        
        public int TimeCircle()
        {
            int wWidth = Console.WindowWidth / 2;
            int wHeigth = Console.WindowHeight / 2;
            int minutes = DateTime.Now.Minute;

            return minutes;
        }
    }


}
