
namespace tabuleiro
{
    public class Posicao {  // UMA DETERMINADA POSICAO QUE VAI SERVIR COMO ATRIBUTO DA PECA //
        public int linha { get; set; }
        public int coluna { get; set; }

         public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
         }

        public void definirValores(int linha, int coluna){
             this.linha = linha;
             this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha.ToString() + ',' + coluna.ToString();
        }
    }
}