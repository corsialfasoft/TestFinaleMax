using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMax1
{
	class Program
	{
		static void Main(string[] args)
		{

			int k = StampaPari();
			StampaDispari(k - 1);
		}
		public static int StampaPari()
		{
			int i = 0;
			for(int k = 0; k < 15; k++) {
				Console.WriteLine($"... Numero pari: {i}");
				if(k == 14) {
					return i;
				}
				i += 2;
			}
			return i;
		}
		public static void StampaDispari(int d)
		{
			while(d >= 1) {
				Console.WriteLine($"...Numero dispari:{d}");
				d -= 2;
			}
		}
	}
}


