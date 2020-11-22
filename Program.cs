using System;

namespace array_aula_19_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("array e vetor");

            string[] nomes = new string[2];
            int[] idades = new int[2];

            for (var contador = 0; contador < 2; contador++)
            {
                Console.WriteLine("Digite o nome: ");
                nomes[contador] = Console.ReadLine();
                Console.WriteLine("Digite a idade: ");
                idades[contador] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Nomes Cadastrados:");
            for (var contador = 0; contador < 2; contador++){
                Console.WriteLine("Nome: "+nomes[contador]);
                Console.WriteLine("Idade: "+idades[contador]);
            }
        }
    }
}
