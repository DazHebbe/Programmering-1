using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Logik
    {
        // Jag gör instanser utav mina klasser så att jag kan använda dem.
        Station_1 station1 = new Station_1();
        Station_2 station2 = new Station_2();
        Station_3 station3 = new Station_3();
        
        // Jag startar min logik.
        public void Start()
        {
            station1.S1_Logik();
            S1Value();
        }
        // Jag läser av Inputten från Station 1 och aktiverar metoder utifrån det.
        public void S1Value()
        {
            if (station1.Input == "y")
            {
                station2.S2_Logik();
                S2Value();
            }
            else
            {
                Console.ReadLine();
            }
        }
        // Jag läser av Inputten från Station 2 och aktiverar metoder utifrån det.
        public void S2Value()
        {
            if (station2.Input2 == "1")
            {
                station1.S1_Logik();
                S1Value();
            }
            else if (station2.Input2 == "2")
            {
                station3.S3_Logik();
                S3Value();
            }
            else
            {
                Console.ReadLine();
            }
        }
        // Jag läser av Inputten från Station 3 och aktiverar metoder utifrån det.
        public void S3Value()
        {
            if (station3.Input3 == "y")
            {
                station2.S2_Logik();
                S2Value();
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}
