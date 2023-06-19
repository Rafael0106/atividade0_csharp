using System;

namespace AtividadeNota2
{
    class Program
    {
        static void Main(string[] args)
        {

            int Cont1, Cont2, Cont3, Idade, X;
            double Media, Soma, Peso, Altura, Per;

            Cont1 = 0;
            Cont2 = 0;
            Cont3 = 0;
            Soma = 0;


            Console.WriteLine("Atividade 1");
            for (X = 1; X <= 25; X++)
            {
                Console.Write($"Digite a {X}º idade: ");
                Idade = int.Parse(Console.ReadLine());
                while (Idade <= 0)
                {
                    Console.WriteLine("Idade Inválida.");
                    Console.WriteLine("Digite uma idade maior que ZERO");
                    Idade = int.Parse(Console.ReadLine());
                }
                
                Console.Write($"Digite a {X}º altura: ");
                Altura = double.Parse(Console.ReadLine());
                while (Altura <= 0)
                {
                    Console.WriteLine("Altura Inválida.");
                    Console.WriteLine("Digite uma altura maior que ZERO");
                    Altura = double.Parse(Console.ReadLine());
                }

                Console.Write($"Digite o {X}º peso: ");
                Peso = double.Parse(Console.ReadLine());
                while (Peso <= 0)
                {
                    Console.WriteLine("Peso Inválido.");
                    Console.WriteLine("Digite um peso maior que ZERO");
                    Peso = double.Parse(Console.ReadLine());
                }

                if (Idade > 50)
                {
                    Cont1 = Cont1 + 1;
                }
                else
                {
                    if (Idade >10 && Idade <20)
                    {
                        Cont2 = Cont2 + 1;
                        Soma = Soma + Altura;
                    }
                }
                if(Peso<40)
                {
                    Cont3 = Cont3 + 1;
                }            
            }
            if(Cont2==0)
            {
                Console.WriteLine("Não há pessoas com idade entre 10 e 20 anos.");
            }
            else
            {
                Media = Soma / Cont2;
                Console.WriteLine($"A média de altura das pessoas com idade entre 10 e 20 anos é: {Media}m");
            }

            Per = Cont3 / 25.0 * 100;
                        
            Console.WriteLine($"A quantidade de pessoas com idade superior a 50 anos é {Cont1} e o percentual de pessoas com peso inferior a 40kg é de: {Per}%");
            
            Console.ReadKey();

        }
    }
}
