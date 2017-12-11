using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronThrone
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("lets start the game");
			//Console.ReadLine();
			Game1 newgame = new Game1();			
			Console.WriteLine(newgame.ChooseKingdom());

		}
	}

	public class Game1
	{
		private int kingdomNum = 0;
		public  int _kingdom
		{			
			set {

				kingdomNum = value;
			}

			get
			{
				return kingdomNum;
			}
		}
		public string ChooseKingdom()
		{
			string[] listOfKingdoms = new string[7];
			listOfKingdoms[0] = "Winterfell";
			listOfKingdoms[1] = "RiverRun";
			listOfKingdoms[2] = "Eyrie";
			listOfKingdoms[3] = "CasterlyRock";
			listOfKingdoms[4] = "StromsEnd";
			listOfKingdoms[5] = "HighGarden";
			listOfKingdoms[6] = "Drone";

			Console.WriteLine("*******Choose your kingdom********");
			int i = 1;
			foreach (string kingdom in listOfKingdoms)
			{
				Console.WriteLine(i + "->" + kingdom);
				i++;
			}

			string coosenKingdomNum = Console.ReadLine();
			int kingdomNum = int.Parse(coosenKingdomNum);
			return ("Your kingdom is " + listOfKingdoms[kingdomNum - 1]);
		}
	}
}
