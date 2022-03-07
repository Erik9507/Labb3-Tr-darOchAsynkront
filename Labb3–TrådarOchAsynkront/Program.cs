using System;
using System.Threading.Tasks;
using System.Threading;

namespace Labb3_TrådarOchAsynkront
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla tesla1 = new Tesla();
            Volvo volvo1 = new Volvo();

            Thread t1 = new Thread(tesla1.Racing);
            Thread t2 = new Thread(tesla1.CarError);


            Thread v1 = new Thread(volvo1.Racing);
            Thread v2 = new Thread(volvo1.CarError);


            t1.Start();
            v1.Start();
            t2.Start();
            v2.Start();                   
            Bil.PrintRace(tesla1, volvo1);
            
        
        }
    }
}
