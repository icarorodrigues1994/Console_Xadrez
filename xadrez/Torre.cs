using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
     class Torre : Peca {
        
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor){

        }

        public override string ToString()
        {
            return "T";
            
        }

        
        private bool podeMover(Posicao pos){   // Validando se eu posso mover a peça
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor; // A peça naquela posição do tabuleiro está vazia ou a peça que peça ques estiver la é de outra cor.
        }


          public override bool [,] movimentosPossiveis(){
            bool [,] mat = new bool [tab.linhas, tab.colunas]; // a matriz vai ter o mesmo tamanho do tabuleiro
            
            Posicao pos = new Posicao(0,0);     // instanciando uma posição que vai servir como referencia


            //Casas Acima da torre
            pos.definirValores(posicao.linha -1, posicao.coluna);  // definindo uma nova posicao para o 'pos'.
            while(tab.posicaoValida(pos) && podeMover(pos)){  // validando ESQUANTO a posição é verdadeira e se realmente é possivel se mover para aquela posição.
                mat[pos.linha,pos.coluna] = true;  // nessa posição atual a torre pode ir para essa casa

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor){ // SE 
                    break;
                }

                pos.linha = pos.linha - 1;
            }

            //Casas abaixo da torre
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha,pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor){
                    break;
                }

                pos.linha = pos.linha + 1;
            }

            //Casas direta da torre
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha,pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor){
                    break;
                }

                pos.coluna = pos.coluna + 1;
            }


            //Casas Esquerda da torre
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha,pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor){
                    break;
                }

                pos.coluna = pos.coluna - 1;
            }

        return mat;

    }
}

}