using System;
using System.Collections.Generic;

namespace Objeto_Argumento.Classes
{
    public class Carrinhos
    {
        public float ValorTotal { get; set; }

        List<Produtos> carrinhos = new List<Produtos>();
              

        public void AdicinarProduto(Produtos produto){
            carrinhos.Add(produto);

        }
        public void MostrarMenu(){
            Console.WriteLine(" Escolha uma Opcão");
            Console.WriteLine("[1]Mostrar Produtos");
            Console.WriteLine("[2]Escolher Produto");
            Console.WriteLine("[3]Alterar Produto");
            Console.WriteLine("[4]Remover produto");
            Console.WriteLine("[5]Adicionar Produto");
            int opicao = int.Parse(Console.ReadLine());

            switch (opicao)
            {
                case 1:
                MostrarProdutos();
                    break;
                default:
                    break;
            }
            
        }
        public void RemoverProdutos(Produtos produtos){
            carrinhos.Remove(produtos);
        }
        public void MostrarProdutos(){
           if(carrinhos != null){
                foreach(var item in carrinhos){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R${item.Preco.ToString("n2")} - Nome {item.Nome}");
                    Console.ResetColor();
                }

            }
        }

        // internal void RemoveProdutos()
        // {
        //     throw new NotImplementedException();
        // }
        public void AlterarItem(int _codigo){
            carrinhos.Find(X => X.Codigo == _codigo);
            
        }

        internal void listaDeProdutos(Produtos produto)
        {
            //throw new NotImplementedException();
        }
    }
}