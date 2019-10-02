namespace Aula14.Model
{
    public class ProdutoModel
    {
        public int idProduto {get;set;}
        public string nomeProduto {get;set;}
        public string descricao {get;set;}
        public double preco{get;set;}

        public ProdutoModel(int idProduto, string nomeProduto, string descricao, double preco){
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.descricao = descricao;
            this.preco = preco;
        }

        //utilizamos sobrecarga para poder instanciar passando ou nao os atributos/parametros/argumentos
        public ProdutoModel(){

        }
    }
}