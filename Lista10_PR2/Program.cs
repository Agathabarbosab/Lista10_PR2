using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            do
            {
                Console.WriteLine("======Menu======");
                Console.WriteLine("exercicio 1 - Digite1");
                Console.WriteLine("exercicio 2 - Digite2");
                Console.WriteLine("exercicio 3 - Digite3");
                Console.WriteLine("exercicio 4 - Digite4");
                Console.WriteLine("Digite 0 - caso queira sair:");

                exercicio = int.Parse(Console.ReadLine());

                switch (exercicio)
                {
                    case 0:
                        Console.WriteLine("Obrigada por utilizar este programa!!!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;

                        ;


                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
            } while (exercicio != 0);


        }
    }
}
