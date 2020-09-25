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

	}
}
