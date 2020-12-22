using System;
using CsharpOO2;

namespace CsharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("preto");
        
            meuCarro.marca = "Fiat";
            meuCarro.modelo = "Siena";
            
            Console.WriteLine("Situação do carro:" + meuCarro.verificaSituacaoDetran("PVE-7815"));
            Console.WriteLine("Marca: "+ meuCarro.marca + " - Modeo: "+ meuCarro.modelo + " - Cor: "+ meuCarro.cor);
        }
    }
}
