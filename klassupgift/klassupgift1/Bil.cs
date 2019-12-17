using System;
using System.Collections.Generic;
using System.Text;

namespace klassupgift1
{
	class Bil
	{
		private double maxHastighet;
		private int styrka;
		private string namn;
		public void SetMaxHastighet(double m) {maxHastighet=m;}
		public void SetStyrka(int s) {styrka = s;}
		public void SetNamn(string n) {namn = n;}
		public double GetMaxHastighet() {return maxHastighet; }
		public int GetStyrka() {return styrka; }
		public string GetNamn() {return namn; }

	}
}
