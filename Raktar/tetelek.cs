﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class tetel
    {
		private string kod;

		public string KOD
		{
			get { return kod; }
			set { kod = value; }
		}

		private int db;

		public int DB
		{
			get { return db; }
			set { db = value; }
		}

		public tetel(string kod, int db)
		{
			this.kod = kod;
			this.db = db;
		}

	}
}
