using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class rendeles
    {

		private string datum;

		public string DATUM
		{
			get { return datum; }
			set { datum = value; }
		}

		private string rendelesszam;

		public string RENDELESSZAM
		{
			get { return rendelesszam; }
			set { rendelesszam = value; }
		}

		private string email;

		public string EMAIL
		{
			get { return email; }
			set { email = value; }
		}

		public rendeles(string datum,string rendelesszam,string email)
		{
			
			this.datum = datum;
			this.rendelesszam = rendelesszam;
			this.email = email;
			tetelek = new List<tetel>();


		}

		private List<tetel> tetelek;



		public void tetelhozzaad(string kod,int db)
		{
			tetelek.Add(new tetel(kod, db));

		}



		private int osszeg;

		public int OSSZEG
		{
			get { return osszeg; }
			set { osszeg = value; }
		}

		public void szamolas(List<Termek> termekek)
		{
			//kód alapján megkeresni a terméket
			//szum += ár * darab (ahány termék van)
			int szum = 0;

			for (int i = 0; i < tetelek.Count; i++)
			{
				int ar = ara(tetelek[i].KOD,termekek);
				szum += ar * tetelek[i].DB;
			}

			this.osszeg = szum;

		}


		private int ara(string kod, List<Termek> termekek)
		{
			int i = 0;
			while (termekek[i].KOD !=kod)
			{
				i++;
			}

			return termekek[i].AR;



		}
















	}

}
