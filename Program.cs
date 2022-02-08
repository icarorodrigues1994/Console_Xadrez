﻿// See https://aka.ms/new-console-template for more information
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

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab);

            Console.WriteLine();
            Console.WriteLine("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

            partida.executaMovimento(origem, destino);

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