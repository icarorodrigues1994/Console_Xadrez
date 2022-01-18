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

            
        try{

            
            Tabuleiro tab = new Tabuleiro(8,8);
            
            

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,7));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0,2));

            Tela.imprimirTabuleiro(tab);
            }
        catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}

