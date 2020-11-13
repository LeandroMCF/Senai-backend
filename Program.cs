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

            while (nota1 > 10 || nota2 > 10 || nota3 > 10)
            {
                if (nota1 > 10)
                {
                    Console.Write("Nota inválida, digite a nota 1 novamente: ");
                    nota1 = float.Parse(Console.ReadLine());
                }
                if (nota2 > 10)
                {
                    Console.Write("Nota inválida, digite a nota 2 novamente: ");
                    nota2 = float.Parse(Console.ReadLine());
                }
                if (nota3 > 10)
                {
                    Console.Write("Nota inválida, digite a nota 3 novamente: ");
                    nota3 = float.Parse(Console.ReadLine());
                }
            }
            if (media <= 5)
            {
                Console.WriteLine("O aluno "+nome+" não passou de ano");
                Console.WriteLine("Média: "+media);
            }
            else
            {
                Console.WriteLine("O alnuno "+nome+" passou de ano, parabens!");   
                Console.WriteLine("Média: "+media);
            }
        }
    }
}