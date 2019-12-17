using System;
using System.Collections.Generic;

namespace klassupgift1
{
    class Program
    {
        static void Main()
        {
			Bil fordon1 = new Bil();
			Bil fordon2 = new Bil();

			fordon1.SetNamn("skruttBil");
			fordon1.SetMaxHastighet(12);
			fordon1.SetStyrka(1);
			fordon2.SetNamn("hyfsadBil");
			fordon2.SetMaxHastighet(180);
			fordon2.SetStyrka(6);

			List<Bil> listOfBilar = new List<Bil>();
			PrintIt(listOfBilar);
		}

		static void PrintIt(List<Bil> objList)
		{
			foreach (Bil item in objList)
			{
				Console.WriteLine(item.GetNamn());
				Console.WriteLine(item.GetStyrka());
				Console.WriteLine(item.GetMaxHastighet());
			}
		}
		
    }
}
