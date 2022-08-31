using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Carro : Vehiculo
    {
        public int Peso { get; set; }
        public int CanLLantas{ get; set; }
        
        public Carro(string modelo, string marca, string color, int peso, int canLLantas) : base(modelo, marca, color)
        {
            this.Peso = peso;
            this.CanLLantas = canLLantas;
        }

        public string GirarIzq(int grados)
        {
            return "El carro giro " + grados + " grados a la izquierda";
        }
    }
}
