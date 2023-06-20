using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculodemedia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numero1, numero2, numero3, numero4, media;

            Console.Write("digite nota 1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("digite nota 2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("digite nota 3: ");
            numero3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("digite nota 4: ");
            numero4 = Convert.ToDouble(Console.ReadLine());

            
            media = (numero1 + numero2 + numero3 + numero4) / 4;
            
            Console.WriteLine("========================================");
           
            if (media >= 7)
            {
                Console.WriteLine("aluno aprovado");
            }
            else
            {
                Console.WriteLine("aluno reprovado");
            }
            Console.WriteLine("========================================");

            










        }
    }
}
