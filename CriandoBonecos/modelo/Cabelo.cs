using System;
using System.Collections.Generic;
using System.Text;

namespace ExibiçãoDePedidos.modelo
{
    class Cabelo
    {
        private int tamanho;
        private string estilo;
        private string tipo;
        private string cor;

        public Cabelo() { }
        public Cabelo(int tamanho, string estilo, string tipo, string cor)
        {
            this.tamanho = tamanho;
            this.estilo = estilo;
            this.tipo = tipo;
            this.cor = cor;
        }

        public int Tamanho
        {
            get { return tamanho; }
            set { this.tamanho = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { this.cor = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }
        }
        public string Estilo
        {
            get { return estilo; }
            set { this.estilo = value; }
        }
        public override string ToString()
        {
            return estilo;
        }
    }
}
