using System;
using System.Collections.Generic;
using System.Text;

namespace ExibiçãoDePedidos.modelo
{
    class Calcado
    {
        private string modelo;
        private string cor;
        private int tamanho;

        public Calcado()
        {

        }

        public Calcado(string modelo, string cor, int tamanho)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.tamanho = tamanho;
        }

        public string Modelo
        {
            get { return modelo; }
            set { this.modelo = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { this.cor = value; }
        }
        public int Tamanho
        {
            get { return tamanho; }
            set { this.tamanho = value; }
        }

        public override string ToString()
        {
            return modelo;
        }
    }
}
