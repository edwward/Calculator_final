using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
	class Kalkulacka
	{
		public double Vysledek; //verejna vlastnost, se kterou pracujeme v main
		public void Vypocitej(string operace, double cislo) //kalkulacka nic nevraci, pouze modifikuje hodnotu vlastnosti Vysledek - vypočítaný výsledek si v mainu přečteme v této vlastnosti
		{
			switch (operace)
			{
				case "+":
					Vysledek += cislo;
					break;
				case "-":
					Vysledek -= cislo;
					break;
				case "*":
					Vysledek *= cislo;
					break;
				case "/":
					Vysledek /= cislo;
					break;
			}
		}
		//další varianta je nemít vlastnost Vysledek a místo metody, která nevrací nic (void) mít metodu, která přímo vrací double - nezapomeň pak ale v mainu načíst výsledek volání metody do proměnné (více viz kalkulačka od Iva)
	}
	

}


