using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Labb3_TrådarOchAsynkront
{
    public abstract class Bil
    {
        public List<string> Log { get; set; }      
        public bool gas = false;
        public bool flat = false;
        public bool bird = false;
        public decimal distance = 0.00m;
        public int raceDistance = 1001;
        public string name;
        public int Speed = 60;


        public static void PrintRace(Tesla t, Volvo v)
        {
            while (!(Tesla.TeslaWinner && Volvo.VolvoWinner))
            {
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Teslan har åkt " + t.distance + " m" + "                                             Volvon har åkt " + v.distance + " m");
                if (t.Log.Count > 0)
                {
                    int i = 0;
                    foreach (var item in t.Log)
                    {
                        i++;
                        Console.SetCursorPosition(0, 2 + i);
                        Console.WriteLine("Teslans Log " + item);
                    }
                }
                if (v.Log.Count > 0)
                {
                    int i = 0;
                    foreach (var item in v.Log)
                    {
                        i++;
                        Console.SetCursorPosition(65, 2 + i);
                        Console.WriteLine("Volvons Log " + item);
                    }
                }                              
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Racet är färdigt!");
            Console.ReadLine();
        }       
        public void SlutPåBensin(List<string> Log)
        {
            Random r1 = new Random();
            if (r1.Next(1,51)==1)
            {
                gas = true;
                Log.Add("Tanka. detta tar 30 sekunder.");
                Thread.Sleep(30000);
            }
        }
        public void Punktering(List<string> Log)
        {
            Random r2 = new Random();
            if (r2.Next(1,26)==1)
            {
                flat = true;
                Log.Add("Byta däck. detta tar 20 sekunder");
                Thread.Sleep(20000);
            }        
        }
        public void FågelPåVindrutan(List<string> Log)
        {
            Random r3 = new Random();
            if (r3.Next(1,11)==1)
            {
                bird = true;
                Log.Add("Tvätta vindrutan. detta tar 10 sekunder");
                Thread.Sleep(10000);
            }           
        }
        public void Motorfel(List<string> Log)
        {
            Random r4 = new Random();
            if (r4.Next(1,6)==1)
            {              
                Log.Add("Motorfel. Bilens hastighet sänks");
                Speed = Speed+10;                
            }          
        }
    }
}
