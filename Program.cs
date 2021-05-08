using System;

namespace MediaNota
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal Nota1, Nota2, Nota3, Nota4, Media;

            Console.WriteLine("--Média--");
            Console.WriteLine("Digite as notas abaixo:");
            Console.Write("Nota1: ");
            Nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota2: ");
            Nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota3: ");
            Nota3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota4: ");
            Nota4 = Convert.ToDecimal(Console.ReadLine());

            Media= (Nota1+Nota2+Nota3+Nota4) / 4;
            
            if (Media>=6 && Media<=10)
            {
                Console.WriteLine($"Sua média é {Media:N1}. Você foi aprovado, eba!");
            }
            else if (Media>=5 && Media< 6)
            {
                Console.WriteLine($"Sua média é {Media:N1}. Você está de recuperação.");
            }
            else if(Media>=0 && Media< 5)
            {
                Console.WriteLine($"Sua média é {Media:N1}. Você foi reprovado, que tristeza.");
            }
            else
            {
                Console.WriteLine("Digite apenas notas entre 0 e 10.");
            }
        }
    }
}
