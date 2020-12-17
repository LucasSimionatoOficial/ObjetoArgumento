using System;
using System.Collections.Generic;

namespace ObjetoArgumento.classes
{
    public class Carrinho
    {
        public float ValorTotal{get;set;}
        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }

        public void MostrarProdutos(){
            if(carrinho != null){
                foreach (var item in carrinho){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" R$ {item.Preco.ToString("n2")} - {item.Nome}");
                }
            }
        }

        public void MostrarTotal(){
            Console.ForegroundColor = ConsoleColor.Blue;

            if(carrinho != null){
                foreach (var item in carrinho){
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"Total do Carrinho: R$ {ValorTotal.ToString("n2")} ");
            }else{
            Console.WriteLine("Seu carrinho ainda está vazio");
            }
            Console.ResetColor();
        }

        public void AlterarItem(int _codigo, Produto _NovoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _NovoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _NovoProduto.Preco;
        }
    }
}