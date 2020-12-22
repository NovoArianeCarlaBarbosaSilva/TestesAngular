using System;

namespace CsharpOO2
{

    public class Veiculo 
    {
        public string cor { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

    }
    public class Carro : Veiculo
    {
        public Carro(string cor){
            
        }
        public string verificaSituacaoDetran(string placa)
        {
            return "Carro ok";
        }

    }
}