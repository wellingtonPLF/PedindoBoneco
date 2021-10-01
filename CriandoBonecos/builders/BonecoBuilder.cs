using System;
using System.Collections.Generic;
using System.Text;
using ExibiçãoDePedidos.interfaces;
using ExibiçãoDePedidos.modelo;

namespace ExibiçãoDePedidos.builders
{
    class BonecoBuilder : IBuilder
    {
        private Cabelo cabelo;
        private Camisa camisa;
        private Calca calca;
        private Calcado calcado;
        private Arma arma;

        public IBuilder setCabelo(Cabelo cabelo)
        {
            this.cabelo = cabelo;
            return this;
        }

        public IBuilder setCamisa(Camisa camisa)
        {
            this.camisa = camisa;
            return this;
        }
        public IBuilder setCalca(Calca calca)
        {
            this.calca = calca;
            return this;
        }
        public IBuilder setCalcado(Calcado calcado)
        {
            this.calcado = calcado;
            return this;
        }        
        public IBuilder setArma(Arma arma)
        {
            this.arma = arma;
            return this;
        }

        public Boneco getResult()
        {
            return new Boneco(
                cabelo, 
                camisa, 
                calca, 
                calcado, 
                arma);
        }
    }
}
