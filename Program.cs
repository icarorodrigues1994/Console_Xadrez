// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez {

    class Program {
        static void Main (string [] args ){


            Tabuleiro tab = new Tabuleiro(1,2);
            Posicao p = new Posicao(1,2);

            
            Console.WriteLine(p);
            


        }
    }
}

