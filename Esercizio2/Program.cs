using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
	class Program
	{
		static void Main(string[] args)
		{
			Controller controller = new Controller();
			string frase= Inserisci("Inserisci la tua frase...");
			controller.Conta(frase);
			List <Occorrenze> trovate = controller.GetOccorrenze();
			Stampa(trovate);
		}
		public static string Inserisci(string mess)
		{
			Console.WriteLine($"{mess}");
			return Console.ReadLine();
		}
		public static void Stampa(List<Occorrenze> occorrenza)
		{
			foreach(Occorrenze element in occorrenza) {
				Console.WriteLine(element);
			}
		}

	}
	public class Controller
	{
	public List<Occorrenze> occorrenze = new List<Occorrenze>();
	public  void Conta(string frase) {
			
			string [] parole;
			string[] separatori = {",", ".", "!", "?", ";", ":", " "};
			parole = frase.ToLower().Split(separatori,StringSplitOptions.RemoveEmptyEntries);
				foreach (string parola in parole){
				Occorrenze occorrenza= new Occorrenze{Parola=parola,Ripetizioni=1};
					if(!Check(occorrenza)){
					occorrenze.Add(occorrenza);
					}
				}
			}
	public bool Check(Occorrenze a)
		{
			foreach (Occorrenze occorrenza in occorrenze) {
				if(occorrenza.Equals(a)) {
					occorrenza.Ripetizioni +=1;
					return true;
				}
			}
			return false;
		}
	public List<Occorrenze> GetOccorrenze() {
			return occorrenze;
		}

	}
	public class Occorrenze
	{
		public int Ripetizioni {get;set;}
		public string Parola {get;set;}
		public Occorrenze() { }
		public override string ToString()
		{
			return $"La parola --> {this.Parola}<--- si presenta  {this.Ripetizioni} volte";
		}
		public override bool Equals(Object obj)
		{
			Occorrenze occorrenza = (Occorrenze) obj;
			if (this.Parola == occorrenza.Parola){
				return true;
			} else {
				return false;
			}
		}
	}
}

