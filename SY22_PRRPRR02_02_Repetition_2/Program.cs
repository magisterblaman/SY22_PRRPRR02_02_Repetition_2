using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			bool isRunning = true;

			while (isRunning) {
				Console.WriteLine("Vill du fortsätta köra?");
				string reply = Console.ReadLine().ToLower();
				if (reply == "nej" || reply == "no") {
					isRunning = false;
				}

			}
		}
	}
}
