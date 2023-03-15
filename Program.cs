// Condicionais Vítima // Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

//“Telefonou para a vítima? “
//"Esteve no local do crime?”
//“Mora perto da vítima? “
//“Devia para a vítima? “
//“Já trabalhou com a vítima? “

//- O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. 
//- Se a pessoa responder positivamente a 2 questões ela deve ser classificada como “Suspeita”, entre 3 e 4 como “Cúmplice” e 5 como “Assassino“. 
//- Caso contrário, ele será classificado como “Inocente“.

using System;

namespace CondicionalCrime
{
    class Program

    {
        static void Main(string[] args)
        {
            int pontuacao = 0;
            Console.WriteLine("Voce foi chamado para depor sobre um crime e deve responder às seguintes perguntas: ");
            Console.WriteLine("Voce telefonou recentemente para a vítima?");
            string primeiraPergunta = Console.ReadLine();

            Console.WriteLine("Esteve no local do crime?");
            string segundaPergunta = Console.ReadLine();

            Console.WriteLine("Mora perto da vítima?");
            string terceiraPergunta = Console.ReadLine();

            Console.WriteLine("Devia dinheiro para a vítima?");
            string quartaPergunta = Console.ReadLine();

            Console.WriteLine("Já trabalhou com a vítima?");
            string quintaPergunta = Console.ReadLine();

            if (primeiraPergunta == "sim")
            {
                pontuacao++;
            }
            if (segundaPergunta == "sim")
            {
                pontuacao++;
            }
            if (terceiraPergunta == "sim")
            {
                pontuacao++;
            }
            if (quartaPergunta == "sim")
            {
                pontuacao++;
            }
            if (quintaPergunta == "sim")
            {
                pontuacao++;
            }
            
            if (pontuacao == 2)
            {
                Console.WriteLine("Voce é suspeito");
            }
            else if (pontuacao >= 3 && pontuacao <= 4)
            {
                Console.WriteLine("Voce é cúmplice");
            }
            else if (pontuacao == 5)
            {
                Console.WriteLine("Voce é o assassino");
            }
            else if(pontuacao <2)
            {
                Console.WriteLine("Voce é inocente");
            }
        }
    }
}