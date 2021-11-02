using System;

namespace aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            // exp1
            //    Console.WriteLine("informe dois numeros e decidirei o maior.");
            //    int n1 = int.Parse(Console.ReadLine()); 
            //    int n2 = int.Parse(Console.ReadLine());
            //    if(n1>n2)
            //         {
            //             Console.WriteLine("o maior numero é {0}",n1);
            //         }
            //     else
            //         {
            //             Console.WriteLine("o maior numero é {0}",n2);
            //         }


            // exp2
            // Console.Write("Informe a nota 1:");
            // int n1 = int.Parse(Console.ReadLine());

            // Console.Write("Informe a nota 2:");
            // int n2 = int.Parse(Console.ReadLine());

            // Console.Write("Informe a nota 3:");
            // int n3 = int.Parse(Console.ReadLine());

            // Console.Write("Informe a nota 4:");
            // int n4 = int.Parse(Console.ReadLine());

            // var med = (n1+n2+n3+n4)/4;

            // if(med>7)
            // {
            //     Console.WriteLine("Aprovado!");
            // }
            // else
            // {
            //     Console.WriteLine("reprovado!");
            // }

            // desafio
            // int saldo=1000;
            // Console.Write("Informe o valor a ser sacado:");
            // int saque = int.Parse(Console.ReadLine());
            // if(saque<=saldo)
            //     {
            //         // Efetuar saque
            //         Console.Write("saque efetuado, o novo saldo é:");
            //         saldo = saldo - saque;
            //         Console.WriteLine(saldo);
            //     }
            // else
            //     {
            //         Console.WriteLine("Saldo insuficiente.");
            //     }


            // exp1
            // Console.Write("Informe a nota 1:");
            // int n1 = int.Parse(Console.ReadLine());

            // Console.Write("Informe a nota 2:");
            // int n2 = int.Parse(Console.ReadLine());

            // Console.Write("Informe a nota 3:");
            // int n3 = int.Parse(Console.ReadLine());

            // Console.Write("Informe a nota 4:");
            // int n4 = int.Parse(Console.ReadLine());

            // var med = (n1 + n2 + n3 + n4) / 4;

            // if (med >= 7)
            // {
            //     Console.WriteLine("Aprovado!");
            // }
            // else
            //     if (med >= 4)
            // {
            //     Console.WriteLine("recuperação!");
            // }
            //     else
            // {
            //     Console.WriteLine("Reprovado!");
            // }

            // desafio
        //     Console.WriteLine("Digite um numero e informarei se é divisivel por 5");
        //     int n1 = int.Parse(Console.ReadLine());
        //     if((n1%5)==0)
        //     {
        //         Console.WriteLine("O numero é divisivel por 5.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("O numero não é divisivel por 5.");
        //     }
        // }
        
        
        // desafio 2
            // Console.WriteLine("Informe três numeros e exibirei o menor");
            // Console.Write("Informe o numero 1:");
            // int n1 = int.Parse(Console.ReadLine());

            // Console.Write("Informe o numero 2:");
            // int n2 = int.Parse(Console.ReadLine());

            // Console.Write("Informe o numero 3:");
            // int n3 = int.Parse(Console.ReadLine());
            
            // if(n1<n2)
            // {
            //     if(n1<n3)
            //     {
            //         Console.WriteLine(n1);
            //     }
            //     else
            //     {
            //         Console.WriteLine(n3);
            //     }
            // }
            // else
            // {
            //     if(n2<n3)
            //     {
            //         Console.WriteLine(n2);
            //     }
            //     else
            //     {
            //         Console.WriteLine(n3);
            //     }

            // desafio 2
            //     Console.WriteLine("Informe três numeros e exibirei o menor");
            // Console.Write("Informe o numero 1:");
            // int n1 = int.Parse(Console.ReadLine());

            // Console.Write("Informe o numero 2:");
            // int n2 = int.Parse(Console.ReadLine());

            // Console.Write("Informe o numero 3:");
            // int n3 = int.Parse(Console.ReadLine());
            
            // if(n1<n2&&n1<n3)
            // {
            //     Console.WriteLine(n1);
            // }
            // else
            // {
            //     if(n2<n3)
            //     {
            //         Console.WriteLine(n2);
            //     }
            //     else
            //     {
            //         Console.WriteLine(n3);
            //     }
            // }


            // desafio 3
            Console.Write("Informe o salário:");
            double s = double.Parse(Console.ReadLine());
            if(s>500)
            {
                Console.WriteLine("Não receberá aumento!");
            }
            else
            {
                s=s*1.1;
                Console.WriteLine("Seu novo salário é {0}!",s);
            }
        }    
    }
}
