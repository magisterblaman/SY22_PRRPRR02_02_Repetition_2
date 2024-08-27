using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			List<int> uniqueNumbers = new List<int>();

			bool run = true;

			while (run) {
				Console.Clear();

				Console.WriteLine("Vänligen mata in ett heltal");

				string input = Console.ReadLine();
				int number = int.Parse(input);

				int matchIndex = -1;

				for (int i = 0; i < uniqueNumbers.Count; i++) {
					if (number == uniqueNumbers[i]) {
						matchIndex = i;
					}
				}

				if (matchIndex != -1) {
					for (int i = 0; i < matchIndex; i++) {
						uniqueNumbers.RemoveAt(0);
					}
					for (int i = 0; i < uniqueNumbers.Count; i++) {
						Console.WriteLine(i);
					}
				} else {
					uniqueNumbers.Add(number);
				}

				Console.WriteLine("Vill du fortsätta?");
				string response = Console.ReadLine();
				if (response == "nej") {
					run = false;
				}

			}

		}
	}
}
