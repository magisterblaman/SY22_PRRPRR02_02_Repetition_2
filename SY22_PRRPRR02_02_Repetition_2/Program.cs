using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			
			for (int i = 10; i > 0; i--) {
				for (int j = 0; j < i; j++) {
					Console.Write('*');
				}
				Console.WriteLine();
			}
		}
	}
}
