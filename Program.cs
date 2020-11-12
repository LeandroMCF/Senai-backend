using System;

namespace Senai_backend
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, media;
            string nome;

            Console.Write("Digite o nome do alono: ");
            nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3)/3;

            if (media <= 5)
            {
                Console.WriteLine("O aluno "+nome+" não passou de ano");
                Console.WriteLine(media);
            }
            else
            {
                Console.WriteLine("O alnuno "+nome+" passou de ano, parabens!");   
                Console.WriteLine(media);
            }
        }
    }
}