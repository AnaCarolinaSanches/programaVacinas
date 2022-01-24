using System;

namespace ControleVacinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qual vacina você tomou, Coronavac ou Jassen?");
            string VacinaUsuario = Console.ReadLine();

            Console.WriteLine("Digite qual a data em que você tomou?");
            DateTime dataDaVacina = DateTime.Parse(Console.ReadLine());

            switch (VacinaUsuario)
            {
                case "Coronavac":
                {
                    dataDaVacina = dataDaVacina.AddDays(14);
                    Console.WriteLine("Sua Proxima dose sera em: " + dataDaVacina ); 
                    break;
                }
                case "Jassen":
                {
                    Console.WriteLine("Vacina de dose única!");
                    break;    
                }    
                default:
                {
                    Console.WriteLine("Dados inválidos");
                    break;
                }
                    
            }   


            /*if (VacinaUsuario == "Coronavac")
            {
                dataDaVacina = dataDaVacina.AddDays(14);
                Console.WriteLine("Sua Proxima dose sera em: " + dataDaVacina );
            }
            else
            {
                Console.WriteLine("Vacina dose unica");

            //int dia = dataDaVacina.Day;
            //int mes = dataDaVacina.Month;
            //int ano = dataDaVacina.Year;
            } */                      
            
        }
    }
}