using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
     class Rei : Peca {
        
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor){

        }

        public override string ToString()
        {
            return "R";
            
        }

        private bool podeMover(Posicao pos){   // Validando se eu posso mover a peça
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor; // A peça naquela posição do tabuleiro está vazia ou a peça que peça ques estiver la é de outra cor.
        }


          public override bool [,] movimentosPossiveis(){
            bool [,] mat = new bool [tab.linhas, tab.colunas]; // a matriz vai ter o mesmo tamanho do tabuleiro
            
            Posicao pos = new Posicao(0,0);

            //Casa acima do Rei
            pos.definirValores(posicao.linha - 1, posicao.coluna); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

            //Casa nordeste do Rei
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

             //Casa direita do Rei
            pos.definirValores(posicao.linha, posicao.coluna + 1); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

             //Casa sudeste do Rei
            pos.definirValores(posicao.linha+ 1, posicao.coluna + 1); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

             //Casa abaixo do Rei
            pos.definirValores(posicao.linha + 1, posicao.coluna); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

            //Casa sudoeste do Rei
            pos.definirValores(posicao.linha + 1, posicao.coluna -1); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

            //Casa esquerda do Rei
            pos.definirValores(posicao.linha, posicao.coluna -1); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

             //Casa noroeste do Rei
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1); // definindo uma nova posicao para o 'pos'.
            if (tab.posicaoValida(pos) && podeMover(pos)){  // validando se a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha, pos.coluna] = true; // Se passar na validação, insiro um true na matriz na posição que o rei pode se mover.
            }

            return mat;

          }

    }
}