using System;

namespace project{
	class main{
		static void Main(string[] args){
			string garoto, garota;
			Random love = new Random();
			int number = love.Next(100);
			
			Console.Write("Nome do Garoto: ");
			garoto = Console.ReadLine();
			
			Console.Write("Nome da menina: ");
			garota = Console.ReadLine();
			
			Console.WriteLine("Nivel do amor entre vcs: " + 
			number);
			
			if(number == 100){
				Console.WriteLine("Ta brabo, consagrado");
			}
			else if(number >= 70){
				Console.WriteLine("Ta poha! Ta quase");
			}
			else if(number >= 40){
				Console.WriteLine("Ainda ha chances");
			}
			else if(number >= 20){
				Console.WriteLine("Se conheceram agora? ");
			}
			else if(number >= 0){
				Console.WriteLine("Desistir é pros fracos.");
				Console.WriteLine("Ideal é nem tentar.");
			}
		}
	}
}
