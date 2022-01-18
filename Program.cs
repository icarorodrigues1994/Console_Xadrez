// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace Xadrez {

    class Program {
        static void Main (string [] args ){

            

                PosicaoXadrez pos = new PosicaoXadrez('c',7);
                Console.WriteLine(pos.toPosicao());
            
        }
    }
}

