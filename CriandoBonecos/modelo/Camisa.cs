using System;
using System.Collections.Generic;
using System.Text;

namespace ExibiçãoDePedidos.modelo
{
    class Camisa
    {
        private string modelo;
        private string cor;
        private string tecido;
        private string largura;

        public Camisa()
        {

        }

        public Camisa(string modelo, string cor, string tecido, string largura)
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
        public string Largura
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
