using System;

namespace aula_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // soma +
            // subtração -
            // divisão /
            // multiplicação *
            // resto da divisão %

            // exp 1
            // int n1, n2;
            // Console.WriteLine("digite o primeiro");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("digito o segundo");
            // n2 = int.Parse(Console.ReadLine());
            // Console.Write("O resultado é:" + n1 *n2);

            // exp 2
            // int n1, n2, n3;
            // Console.WriteLine("digite o primeiro");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("digito o segundo");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("digite o terceiro");
            // n3 = int.Parse(Console.ReadLine());
            // var R = n1+n2+n3;
            // Console.Write("O resultado é:" + R);

            // exp3
            // int n1, n2;
            // Console.WriteLine("digite o primeiro");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("digito o segundo");
            // n2 = int.Parse(Console.ReadLine());
            // var R = n1-n2;
            // Console.Write("O resultado é:" + R);

            // exp4
            // int n1, n2;
            // Console.WriteLine("digite o primeiro");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("digito o segundo");
            // n2 = int.Parse(Console.ReadLine());
            // var R = n1/n2;
            // Console.Write("O resultado é:" + R);

            // exp5
            // int n1, n2;
            // Console.WriteLine("digite o primeiro");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("digito o segundo");
            // n2 = int.Parse(Console.ReadLine());
            // var R = n1%n2;
            // Console.Write("O resultado é:" + R);

            // par
            // int n1;
            // Console.WriteLine("digite o numero que você quer saber se é par");
            // n1 = int.Parse(Console.ReadLine());
            // var R = n1%2;
            // Console.Write("é par se igual a 0:" + R);

            // desafio
            // int n1, n2;
            // Console.WriteLine("digite o primeiro");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("digito o segundo");
            // n2 = int.Parse(Console.ReadLine());
            // var s = n1+n2;
            // var su = n1-n2;
            // var d = n1/n2;
            // var m = n1*n2;
            // Console.WriteLine("soma:" + s);
            // Console.WriteLine("subtração:" + su);
            // Console.WriteLine("divisão:" + d);
            // Console.WriteLine("multiplicação:" + m);
            
            // desafio 2
            int n1, n2;
            Console.WriteLine("digite o primeiro");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digito o segundo");
            n2 = int.Parse(Console.ReadLine());
            var s = n1 + n2;
            Console.WriteLine("soma:"+s);
            int n3 = int.Parse(Console.ReadLine());
            var r = n3 * s;
            Console.WriteLine("resultado:"+r);
        }
    }
}
