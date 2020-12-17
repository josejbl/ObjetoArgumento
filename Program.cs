using System;
using Objeto_Argumento.Classes;

namespace Objeto_Argumento
{
    class Program
    {
        static void Main(string[] args)
        {
           Produtos produto1 = new Produtos(1,"Boné New era ",180.56f);
           Produtos produto2 = new Produtos(2,"Boné Bilabong ",100.96f);
           Produtos produto3 = new Produtos(3,"Jaqueta Element",490.99f);
           Produtos produto4 = new Produtos(4,"Jaqueta New era ",600);
           Produtos produto5 = new Produtos(5,"shortes Quiqui Silver",456.98f);
           Produtos produto6 = new Produtos(6,"Relogio G-Shok",1200.89f);
           Produtos produto7 = new Produtos(7,"Relogio G-Shok GBA ",789);
           Produtos produto8 = new Produtos(8,"Tênis Oklei  ",400);
           Produtos produto9 = new Produtos(9,"Mochila Oklai ",650);
           Produtos produto10 = new Produtos(10,"Óculos da Oklai ",1700);


            Carrinhos carrinhos = new Carrinhos();
            Carrinhos iten = carrinhos;

          iten.AdicinarProduto(produto4);
          iten.AdicinarProduto(produto5);
           
          iten.AdicinarProduto(produto1);
          iten.AdicinarProduto(produto7);

          carrinhos.MostrarProdutos();
          carrinhos.RemoverProdutos(produto1);
          carrinhos.RemoverProdutos(produto10);

          carrinhos.listaDeProdutos(produto10);

       
        }

    }
}
