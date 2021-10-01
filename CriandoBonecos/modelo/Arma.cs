using System;
using System.Collections.Generic;
using System.Text;

namespace ExibiçãoDePedidos.modelo
{
    class Arma
    {
        private string modelo; //Espada, Arma de Fogo, Luvas de Box, Chicote, Estrelas Ninja;
        private string cor;
        private int tamanho;
        private string estilo; //Ranged, Meele

        public Arma()
        {

        }

        public Arma(string modelo, string cor, int tamanho, string estilo)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.tamanho = tamanho;
            this.estilo = estilo;
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
        public string Estilo
        {
            get { return estilo; }
            set { this.estilo = value; }
        }

        public override string ToString()
        {
            return modelo;
        }
    }
}
