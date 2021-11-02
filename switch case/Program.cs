using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporta:[a]Avião| [c]Carro | [o]Ônibus");
            string esolha = (Console.ReadLine());
            switch(escolha){
                case 'a':
                Console.WriteLine("tempo 50 minutos");
                break;
                case 'c':
                Console.WriteLine("tempo 480 minutos");
                break;
                case 'o':
                Console.WriteLine("tempo 660 minutos");
                break;
                default:
                Console.WriteLine("dado errado");
                break;
            }
        }
    }
}
