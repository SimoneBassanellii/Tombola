using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tombola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //stampa del tabellone 
            tabellone();
            Console.WriteLine();
            
            //stampa della cartella del giocatore 1 e 2 
            Console.WriteLine("Giocatore 1");
            cartella();
            Console.WriteLine();
            Console.WriteLine("Giocatore 2");
            cartella();


            //funzione creazione del tabellone tabellone 
            void tabellone()
            {
                for (int i = 1; i <= 90; i++)
                {
                    Console.Write(i + " ");
                    if (i % 9 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }

            //creazione e riempimento cartella 
            void cartella ()
            {
                List<int> numeri = Enumerable.Range(1, 90).ToList();
                Random rnd = new Random();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        int numeroCasuale = numeri[rnd.Next(numeri.Count)];
                        Console.Write(numeroCasuale + " ");
                        numeri.Remove(numeroCasuale);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
