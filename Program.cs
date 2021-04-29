using System;
//using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
        	Console.Clear();
        	String hour = DateTime.Now.ToString("HH");
        	string name;
        	int age = 1;
        	int fome = 20;
        	int sono = 20;
        	int banho = 10;
        	int sede = 20;
        	string resp;
        	Console.Write("Tamagotchi name: ");
			name = Console.ReadLine();
			Console.WriteLine("Ok!, Hello "+name);
			Console.WriteLine(hour+" horas");

        	while(age < 99 && fome >= 0 && sono >= 0){


        		//JsonConvert.SerializeObject(new {
				//   idade = age,
				//   fome = fome,
				//   sono = sono,
				//   banho = banho,
				//   sede = sede
				//});

				//var json = JsonConvert.SerializeObject(new { age, fome, Location});

				TextWriter text = new StreamWriter("save.txt");

				text.Write(age);

				text.Close();

        		if(hour == hour + 1){
        			fome -= 2;
        			sono -= 2;
        			banho -= 2;
        			sede -= 2;
        		}
        		
        		

	            Console.Write("\n");

	            Console.WriteLine(" ,-.___,-.");
	            Console.WriteLine(" \\_/_ _\\_/");
	            Console.WriteLine("   )O_O(");
	            Console.WriteLine("  { (_) }");
	            Console.Write("   `-^-'     ");
	            Console.WriteLine(name);
	            Console.WriteLine("Idade: "+age);


	            Console.Write("Fome: ");
	            for(int i = 0; i <= fome; i++){
	            	Console.Write("=");
	            	
	            }
	            Console.WriteLine();
	            Console.Write("Sono: ");
	            for(int i = 0; i <= sono; i++){
	            	Console.Write("=");

	            }
	            Console.WriteLine();

	            Console.Write("Sede: ");
	            for(int i = 0; i <= sede; i++){
	            	Console.Write("=");

	            }
	            Console.WriteLine();

	            Console.WriteLine("[1] Dormir");
	            Console.WriteLine("[2] Comer");
	            Console.WriteLine("[3] Beber Água");
	            Console.WriteLine("[4] Tomar Banho");
	            Console.WriteLine("[5] Sair");
	            //break;

	            resp = Console.ReadLine();

	            if(resp == "1"){
	            	Console.Clear();
	            	Console.WriteLine("Dormindo...");
					Console.WriteLine(" ,-.___,-. ZZZZZZZ");
	            	Console.WriteLine(" \\_/_ _\\_/");
	            	Console.WriteLine("   )-_-(");
		            Console.WriteLine("  { (_) }");
		            Console.Write("   `-^-'     ");
		            Console.WriteLine(name);
	            	sono += 1;
	            	System.Threading.Thread.Sleep(5000);
	            	Console.Clear();
	            	if(sono > 20){
	            		Console.WriteLine("Dormiu muito e morreu de Depressão...");
	            		break;
	            	}
	            }if(resp == "2"){
	            	Console.Clear();
	            	Console.WriteLine("Comendo...");
					Console.WriteLine(" ,-.___,-.");
	            	Console.WriteLine(" \\_/_ _\\_/");
	            	Console.WriteLine("   )O_O(");
		            Console.WriteLine("  { (_) }");
		            Console.Write("   `-^-'     ");
		            Console.WriteLine(name);

		            Console.WriteLine("   ________");
		            Console.WriteLine("  /______ /|");
		            Console.WriteLine(" |       | |");
		            Console.WriteLine(" |Pizza &| |");
		            Console.WriteLine(" |Scones | |");
		            Console.WriteLine(" | Mix   | |");
		            Console.WriteLine(" |       | |");
		            Console.WriteLine(" |_______|/");

		            
		            System.Threading.Thread.Sleep(5000);
	            	Console.Clear();
	            	fome += 1;
	            	if(fome > 20){
	            		Console.WriteLine("Comeu muito e morreu...");
	            		break;
	            	}
	            }
	            if(resp == "3"){
	            	Console.Clear();
	            	Console.WriteLine("Bebendo...");
					Console.WriteLine(" ,-.___,-.");
	            	Console.WriteLine(" \\_/_ _\\_/");
	            	Console.WriteLine("   )O_O(");
		            Console.WriteLine("  { (_) }");
		            Console.Write("   `-^-'     ");
		            Console.WriteLine(name);

		            Console.WriteLine("  .-***`-.");
		            Console.WriteLine(" (         )");
		            Console.WriteLine(" |`-.___.-'|");
		            Console.WriteLine(" |.-'***`-.|");
		            Console.WriteLine(" |         |");
		            Console.WriteLine(" |`-.___.-'|");
		            Console.WriteLine(" |         |");
		            Console.WriteLine(" |. ' ** `.|");
		            Console.WriteLine(" |         |");
		            Console.WriteLine("  `-.___.-' ");
		            Console.WriteLine("Água");

		            
		            System.Threading.Thread.Sleep(5000);
	            	Console.Clear();
	            	sede += 1;
	            	if(sede > 20){
	            		Console.WriteLine("Bebeu muita água e morreu...");
	            		break;
	            	}
	            }


        	}

            

        }
    }
}
