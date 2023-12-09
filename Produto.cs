using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendizagemDotNet
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto (string nome, double preco, int quantidade){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        
        public double ValorTotalEmEstoque(){
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            _quantidade += quantidade;
            

        }
        public int Quantidade{
            get {return _quantidade;}
        }

        public void RemoverProdutos(int quantidade){
            _quantidade -= quantidade;
        }
    }
}