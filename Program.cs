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
            PartidaDeXadrez partida = new PartidaDeXadrez();
            partida.colocarPecas();

            while(!partida.terminada){
            
            try{
            Console.Clear();
            
            Tela.imprimirPartida(partida);

            Console.WriteLine(); //PULA LINHA
            Console.WriteLine("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();  // Aqui ja criar uma matriz de boelano para verificar as posições possiveis daquela peça.

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

            Console.WriteLine(); //PULA LINHA
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeDestino(origem,destino);
            

            partida.realizaJogada(origem, destino);

            

            }
            catch (TabuleiroException e){
                 Console.WriteLine(e.Message);
                 Console.ReadLine();
            }

            }
            
            Console.ReadLine();
           
            }

        catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}

            ;