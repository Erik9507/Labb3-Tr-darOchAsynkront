using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Labb3_TrådarOchAsynkront
{
    public class Tesla : Bil
    {
        public static bool TeslaWinner = false;
        public Tesla()
        {
            Log = new List<string>();           
            name = "Tesla";           
        }     
        public void Racing()
        {
            for (decimal Distance = 0.00m; Distance < raceDistance; Distance++)
            {
                if (gas)
                {
                    Thread.Sleep(30000);
                    gas = false;
                }
                if (flat)
                {
                    Thread.Sleep(20000);
                    flat = false;
                }
                if (bird)
                {
                    Thread.Sleep(10000);
                    bird = false;
                }
                Thread.Sleep(Speed);
                distance = Distance;
            }
            TeslaWinner = true;
            if (!Volvo.VolvoWinner)
            {
                Log.Add(name + " Vann!!");
            }
            else
            {
                Log.Add(name + " Gick i Mål!");
            }
        }
        public void CarError()
        {
            while (!TeslaWinner)
            {
                Thread.Sleep(500);
                Random r = new Random();
                switch (r.Next(1, 5))
                {
                    case 1:
                        SlutPåBensin(Log);
                        break;
                    case 2:
                        Punktering(Log);
                        break;
                    case 3:
                        FågelPåVindrutan(Log);
                        break;
                    case 4:
                        Motorfel(Log);
                        break;
                    default:
                        break;
                }
            }           
        }
    }
}
