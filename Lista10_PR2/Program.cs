using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10_PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            float main = int.MinValue, menon = int.MaxValue, soma = 0, media = 0;
            int n;

            Console.WriteLine("Digite o tamanho do vetot:");
            n = int.Parse(Console.ReadLine());
            float[] vet = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um valor:");
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] > main)
                {
                    main = vet[i];

                }
                if (vet[i] < menon)
                {
                    menon = vet[i];

                }
                Console.WriteLine("menor numero:" + menon);
                Console.WriteLine("maior numero: " + main);
                
            }
            for (int i = 0; i < n; i++)
            {

                soma += vet[i];


            }



            media = soma / n;
            Console.WriteLine("media: " + media);



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vetor[{0}]={1}", i, vet[i]);
            }




        }


public static void Exercicio2()
        {
             
            float media = 0, soma = 0;

            Console.WriteLine("Digite o tamanho do vetor:");
            int n = int.Parse(Console.ReadLine());


            float[] vet = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um valor:");
                vet[i] = int.Parse(Console.ReadLine());
                soma += vet[i];
            }


            media = soma / n;
            Console.WriteLine("media: " + media);



            for (int i = 0; i < n; i++)
            {


                if (vet[i] >= media)
                    Console.WriteLine("numero maior ou igual a media vetor [{0}]={1}", i, vet[i]);


            }


        }
        public static void Exercicio3()
        {
            float soma = 0, media = 0;
            int n;


            Console.WriteLine("Digite o tamanho do vetor:");
             n = int.Parse(Console.ReadLine());
            float[] vet = new float[n];
            Random random = new Random();


            for (int i = 0; i < n; i++)
            {
                vet[i] = random.Next(1, 10); 
                soma += vet[i];
            }


            media = soma / n;
            Console.WriteLine("media: " + media);


            for (int i = 0; i < n; i++)
            {


                if (vet[i] >= media)
                    Console.WriteLine("numero maior ou igual a media vetor [{0}]={1}", i, vet[i]);
            }

        }
        public static void Exercicio4()
        {
            Console.WriteLine("Qual o tamanho do vetor?");
            int n = int.Parse(Console.ReadLine());
            string[] vet = new string[n];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os nomes:");
                vet[i] = Console.ReadLine();

            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vetor[{0}]={1}", i, vet[i]);
            }


            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("vetor[{0}]={1}", i, vet[i]);
            }

        }
       
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
                    
                        


                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
            } while (exercicio != 0);


        }
    }
}
