using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {

        static void beolvas_raktar()
        {
            StreamReader sr = new StreamReader("raktar.csv");
            while (!sr.EndOfStream) 
            {
                /*
                 sor[0] -> kod
                 sor[1] -> ár stb
                 
                 */
                string[] sor = sr.ReadLine().Split(';');
                Console.WriteLine(sor[0]);
                


            }

            sr.Close();
        }
        static void Main(string[] args)
        {
            beolvas_raktar();
            Termek t = new Termek("P01","XL",1500,10);


            

            Console.ReadKey();
        }
    }
}
