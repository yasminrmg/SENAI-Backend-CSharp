namespace POO.Produtos.Model
{
    public class ProdutosModel
    {
        public int IdProduto{get;set;}

        public string NomeProduto{get;set;}

        public string Descricao{get;set;}

        public double Preco{get;set;}

        public FornecedoresModel Fornecedor {get;set;}
    }
}