using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			Console.WriteLine("Hur gammal är din hund?");

			string response = Console.ReadLine();

			int dogAge = int.Parse(response);

			if (dogAge > 13) {
				Console.WriteLine("Din hund är nog död.");
			} else if (dogAge > 8) {
				Console.WriteLine("Om fem år är din hund nog död.");
			} else {
				Console.WriteLine("Om fem år är din hund " + (dogAge + 5));
			}

		}
	}
}
