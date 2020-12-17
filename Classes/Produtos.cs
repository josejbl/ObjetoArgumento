namespace Objeto_Argumento.Classes
{
    public class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produtos(){

        }


        public Produtos(int codigo, string nome ,float preco){
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;


        }
        
        
        
        
    }
}