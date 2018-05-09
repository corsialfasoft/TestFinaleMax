using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Ordinatore ord = new Ordinatore();
			List<int> ordinata = GetLista("Inserisci 10 numeri");
			Console.WriteLine("===============");
			ord.Ordina(ordinata);
			Stampa(ordinata);
			Console.WriteLine("===============");
			List<int> ordinata1 = GetLista("Inserisci altri 10 numeri");
			Console.WriteLine("===============");
			ord.Ordina(ordinata1);
			Stampa(ordinata1);
			Console.WriteLine("===============");
			Stampa(ord.GetLista3(ordinata,ordinata1));

		}
		public static void Stampa(List<int> lista)
		{
			foreach(int element in lista) {
				Console.WriteLine(element);
			}
		}
		public static List<int> GetLista(string a)
		{
			List<int> daOrdinare=new List<int>();
			Console.WriteLine(a);
			for (int i = 0; i < 10; i++) {
				daOrdinare.Add(int.Parse(Console.ReadLine()));
			}
			return daOrdinare;
		}
	}
	public class Ordinatore
	{
		List<int> merge =  new List<int>();
		public void Ordina(List<int> daOrdinare)
		{
			bool v = false;
			do {
				v = false;
				for(int i = 1; i < daOrdinare.Count; i++) {
					if(i > 0) {
						if(daOrdinare[i] < daOrdinare[i - 1]) {
							int tmp = daOrdinare[i];
							daOrdinare[i] = daOrdinare[i - 1];
							daOrdinare[i - 1] = tmp;
							v = true;
						}
					}
				}
			}while(v==true);
		}
		public List<int> GetLista3(List<int> uno ,List<int> dos)
		{
			IEnumerable<int> lista =uno.Union(dos);
			merge =lista.ToList();
			Ordina(merge);
			return merge;
		}
	}
}
