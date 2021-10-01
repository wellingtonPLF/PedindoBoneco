using System;
using System.Collections.Generic;
using System.Text;

namespace ExibiçãoDePedidos.modelo
{
    class Boneco
    {
        protected Cabelo cabelo;
        public Camisa camisa;
        public Calca calca;
        public Calcado calcado;
        public Arma arma;

        public Boneco()
        {

        }

        public Boneco(Boneco copy)
        {
            if(copy!= null)
            {
                Cabelo = copy.Cabelo;
                Camisa = copy.Camisa;
                Calca = copy.Calca;
                Calcado = copy.Calcado;
                Arma = copy.Arma;
            }
        }

        public Boneco(
            Cabelo cabelo, 
            Camisa camisa, Calca calca, 
            Calcado calcado, Arma arma)
        {
            this.cabelo = cabelo;
            this.camisa = camisa;
            this.calca = calca;
            this.calcado = calcado;
            this.arma = arma;
        }

        public virtual Cabelo Cabelo
        {
            get { return cabelo; }
            set { this.cabelo = value; }
        }
        public virtual Camisa Camisa
        {
            get { return camisa; }
            set { this.camisa = value; }
        }
        public virtual Calca Calca
        {
            get { return calca; }
            set { this.calca = value; }
        }
        public virtual Calcado Calcado
        {
            get { return calcado; }
            set { this.calcado = value; }
        }
        public virtual Arma Arma
        {
            get { return arma; }
            set { this.arma = value; }
        }

        public Boneco Clone()
        {
            return new Boneco(this);
        }

        public override string ToString()
        {
            return string.Format(
                "\n||=====================||" +
                "\n  Boneco: " +
                "\n||=====================||" +
                "\n  cabelo:{0}\n" +
                "  camisa:{1}\n" +
                "  calça:{2}\n" +
                "  calçado:{3}\n" +
                "  arma:{4}\n||=====================||\n", 
                Cabelo, Camisa, Calca, Calcado, Arma);
        }
    }
}
