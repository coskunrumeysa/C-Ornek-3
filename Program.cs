using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Proje_3
{
    internal class Program
    {
        static void Main(string[] args)

        {   //Definition Variables
            string ilkisim;
            string ortaisim;
            string sonisim;
            string tümisim;


            // Get name functions
            Console.Write("İlk İsmi Giriniz :");
            ilkisim = Console.ReadLine();

            Console.Write("Orta İsmi Giriniz :");
            ortaisim = Console.ReadLine();

            Console.Write("Sonuncu İsmi Giriniz:");
            sonisim = Console.ReadLine();


            tümisim = ilkisim +" "+ortaisim +" "+sonisim;

            //Print the screen Names
            Console.Write("İsimler :" + tümisim);

            Console.ReadKey();



        }
    }
}
