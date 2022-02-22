
namespace tabuleiro
{
    public abstract class Peca    // CLASSE PECA PODENDO SER QUALQUER PECA DE QUALQUER JOGO DE TABULEIRO //
    {
        public Posicao posicao { get; set; } 
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

         public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;                // posição inicial nula.
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

          public void incrementarQteMovimentos() {
            qteMovimentos++;
        }

         public void decrementarQteMovimentos() {
            qteMovimentos--;
        }

        public bool existeMovimentosPossiveis(){

            bool[,] mat = movimentosPossiveis();

            foreach (bool x in mat){
               if (x == true){
                   return true;
               }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos){
            return movimentosPossiveis()[pos.linha,pos.coluna];
        }


        public abstract bool [,] movimentosPossiveis();


    }
}




