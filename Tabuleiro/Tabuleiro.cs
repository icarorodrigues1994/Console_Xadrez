using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabuleiro
{
    public class Tabuleiro  // TABULEIRO QUE TAMBÉM PODE SERVIR PARA QUALQUER JOGO DE TABULEIRO //
    {
        public int linhas { get; set; }
        public int colunas { get; set; }    
        private Peca[,] pecas;

         public Tabuleiro(int linhas, int colunas) {    //°Construtor tabuleiro.
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; 
        }

        public Peca peca (int linha, int coluna){
            return pecas[linha, coluna];                // °Retorna uma peça pela linha e coluna.
        }

        public Peca peca (Posicao pos){               // °Retorna uma peça pela posição.
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos){      // °Retorna um booleano perguntando se realmente existe peca naquela posiçao.
            validarPosicao(pos);    // primeiro valida a posicao passada no argumento
            return peca(pos) != null; // retorna um boleano perguntando se existe peca naquela posicao
        }
        
        public void colocarPeca(Peca p, Posicao pos){   //° Colocando uma peca na posicao da matriz e no tabuleiro.
            if(existePeca(pos)){
                throw new TabuleiroException("Já existe uma peça nessa posição!"); //se realmente existe peca, ele diz que ja tem peça na posicao.
            }
            pecas[pos.linha, pos.coluna] = p;  // Define uma posição para a peça dentro da lista de peças do tabuleiro.
            p.posicao = pos; // Define a posição da própria peça, já que inicialmente ela é nula.
        }

        public Peca retirarPeca(Posicao pos){
            if(peca(pos) == null){
                return null;
            }
         
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos){
            if (pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna>=colunas){    // Valida se realmente existe a posicao no tabuleiro
                return false;                                                               // pos.linha>=linhas, no tabuleiro de xadrez de (8,8) a posicao tem que ser de 0 a 7, por isso nao pode ser igual ou maior que 8.
            }                      
            return true;
        }

        public void validarPosicao(Posicao pos){
            if (!posicaoValida(pos)){                                      // no if eu pergunto se o retorno do metodo 'posicaoVálida' é falsa(!), se for ele lança o tratamento de erro.
                throw new TabuleiroException("Posição inválida !!");
            }
        }


    }
}