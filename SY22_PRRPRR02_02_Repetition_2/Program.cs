using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			string[] namn = new string[] { 
				"Axel",
				"Emil",
				"Jessica",
				"Viktor",
				"Martin",
				"Amanda"
			};

			for (int i = 0; i < 6; i++) {
				Console.WriteLine(namn[i]);
			}

			namn[3] = "Sven";

			for (int i = 0; i < 6; i++) {
				Console.WriteLine(namn[i]);
			}


		}
	}
}
