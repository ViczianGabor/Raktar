using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class Termek
    {
        private string kod;
        public string KOD {

            
            get { return kod; }
            set { kod = value; }
        }
        private string nev;

        public string Nev { get { return nev; } set { nev = value; } }

        private int ar;



        public int AR
        {
            get { return ar; }
            set { ar = value; }
        }
        private int db;

        public int DB
        {
            get { return db; }
            set { db = value; }
        }



        public Termek (string kod, string nev, int ar,int db )
        {
            this.kod = kod;
            this.nev = alakit(nev);
            this.ar = ar;
            this.db = db;


        }

        private string alakit(string szo)
        {
            string tmp = "";
            string ekezetes = "áéíóöőúüű";
            string mire = "aeiooouuu";
            

            for (int i = 0; i < szo.Length; i++)
            {
                int hol = ekezetes.IndexOf(szo[i]);
                if (hol > -1)
                {
                    //Console.Write(szo[i]);
                    tmp += mire[hol];
                }
                else
                {
                    tmp += szo[i];

                }
            }
            //Console.WriteLine("\n" + tmp);

           
            return tmp;
        }


    }
}
