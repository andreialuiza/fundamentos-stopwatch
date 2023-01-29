using System;
using System.Threading;

namespace Stopwatch // Note: nome do projeto criado. Ele é uma separação lógicas.
{
    internal class Program  //internal: tipos ou membros internal podem ser acessados no código que faz parte da mesma compilação.
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu ()
        {
           Console.Clear();
           Console.WriteLine("S = Segundos => 10s = 10 segundos");
           Console.WriteLine("M = Minutos => 1m = 1 minuto");
           Console.WriteLine("0 = Sair");
           Console.WriteLine("Quanto tempo deseja contar"); 


           string data = Console.ReadLine().ToLower();
           char type = char.Parse(data.Substring(data.Length - 1,1));
           int time = int.Parse(data.Substring(0, data.Length - 1));
           int multiplier = 1;


           if (type == 'm')
                multiplier = 60;

            if ( time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
                   


        }

        static void PreStart (int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start (int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);           
                
            }    

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
            Menu();


        }
    }
}

// OBS:
// int é uma variável de número inteiro;
// while sempre executa algo dado a uma condição, onde ela deve ser sempre verdadeira e sempre deve ter um incremento. O while trabalha alinhado ao clock do processador, então sua contagem é muito rápida.
// Thread execução atual.
// ToLower converte todos os caracteres digitados para minúsculo.

