using System;

namespace CondicionalCrime
{
    class Program

    {
        static void Main(string[] args)
        {

            int sim = 0;
            Console.WriteLine("Voce foi chamado para depor sobre um crime e deve responder às seguintes perguntas: ");
            Console.WriteLine("Voce telefonou recentemente para a vítima?");
            Console.ReadLine();

            Console.WriteLine("Esteve no local do crime?");
            Console.ReadLine();

            Console.WriteLine("Mora perto da vítima?");
            Console.ReadLine();

            Console.WriteLine("Devia dinheiro para a vítima?");
            Console.ReadLine();

            Console.WriteLine("Já trabalhou com a vítima?");
            Console.ReadLine();

            if (sim >= 2)
            {
                Console.WriteLine("Você é suspeito pelo crime");
            }
            else if (sim >= 3 && sim <= 4)
            {
                Console.WriteLine("Você foi cúmplice do crime");
            }
            else if (sim == 5)
            {
                Console.WriteLine("Você é o assassino!");
            }
            else
            {
                Console.WriteLine("Você é inocente!");
            }

        }
    }
}