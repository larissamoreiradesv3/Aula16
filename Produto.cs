namespace Aula16
{
    public class Produto 
    {
        public Produto(){

        }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public int Codigo { get; set; }

        public Produto(string _nome, string _descricao, int _estoque, int _codigo){
            this.Nome = _nome;
            this.Descricao = _descricao;
            this.Estoque = _estoque;
            this.Codigo = _codigo;
        }
    }
}