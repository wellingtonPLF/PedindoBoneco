using System;
using System.Collections.Generic;
using System.Text;

namespace ExibiçãoDePedidos.modelo
{
    class Calca
    {
        private string modelo;
        private string cor;
        private string tecido;
        private int largura;

        public Calca()
        {

        }

        public Calca(string modelo, string cor, string tecido, int largura)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.tecido = tecido;
            this.largura = largura;
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
        public string Tecido
        {
            get { return tecido; }
            set { this.tecido = value; }
        }
        public int Largura
        {
            get { return largura; }
            set { this.largura = value; }
        }

        public override string ToString()
        {
            return modelo;
        }
    }
}
