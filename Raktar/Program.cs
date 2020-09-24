﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {

        static List<Termek> termekek = new List<Termek>();

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
                termekek.Add(new Termek( sor[0],sor[1],int.Parse(sor[2]),int.Parse(sor[3])));
                
                
                

            }

            sr.Close();
            
           //Console.WriteLine(termekek[0].Nev);
            /*  for (int i = 0; i < termekek.Count; i++)
            {
                Console.WriteLine(termekek[i].KOD+" "+termekek[i].Nev+" "+termekek[i].AR+" "+termekek[i].DB);
            }
            */
        }


        static void rendeles_metodus()
        { 
        
            
        
        
        
        
        
        
        }
        static void Main(string[] args)
        {


            

            beolvas_raktar();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }

            rendeles_metodus();

            Console.ReadKey();
        }
    }
}
