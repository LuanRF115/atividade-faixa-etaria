using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace faixa_etaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool entradaInvalida = false;
            int Idade;

            


            do 
            {
                Console.Write("Digite sua idade: ");
                string Entrada = Console.ReadLine();

                if (int.TryParse(Entrada, out  Idade) && Idade >= 0)
                {
                    entradaInvalida = true;
                }
                else 
                {

                    Console.WriteLine("\nEntrada Invalida. Por favor, tente novamente!\n");
                
                }

            } while (!entradaInvalida);



                Console.ForegroundColor = ConsoleColor.Red;
                    if (Idade <= 12)
                        Console.WriteLine("\nEssa pessoa é uma criança ");
                    else if (Idade <= 17)
                        Console.WriteLine("\nEssa pessoa é um Adolecente ");
                    else if (Idade <= 59)
                        Console.WriteLine("\nEssa pessoa é um Adulto ");
                    else
                        Console.WriteLine("\nEssa pessoa é um Idoso");





               


            Console.ReadKey();
        }


    }
    
}
