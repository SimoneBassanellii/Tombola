using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stampa tabellone al centro dello schermo
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            tabellone();

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
        }
    }
}
