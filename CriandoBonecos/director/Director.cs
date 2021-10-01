using System;
using System.Collections.Generic;
using System.Text;
using ExibiçãoDePedidos.interfaces;
using ExibiçãoDePedidos.modelo;

namespace ExibiçãoDePedidos.director
{
    class Director
    {
        public void constructSamurai(IBuilder builder)
        {
            builder.setCabelo(new Cabelo(50, "Coque", "Liso", "Preto"))
                    .setCamisa(new Camisa("Kimono", "Vermelha", "Algodão", "G"))
                    .setCalca(new Calca("Kimono", "Cinza", "Algodão", 40))
                    .setCalcado(new Calcado("Chinelo", "Castanho", 50))
                    .setArma(new Arma("Espada", "Vermelha", 100,"Melee"));
        }

        public void constructNinja(IBuilder builder)
        {
            builder.setCabelo(new Cabelo(0, "Careca", null, null))
                    .setCamisa(new Camisa("Traje", "Preto", "Algodão", "M"))
                    .setCalca(new Calca("Traje", "Preto", "Algodão", 35))
                    .setCalcado(new Calcado("Tabi", "Preto", 35))
                    .setArma(new Arma("Kunai", "Cinza", 20, "Full"));
        }
        public void constructCowBoy(IBuilder builder)
        {
            builder.setCabelo(new Cabelo(30, "Cacheado", "Liso", "Castanho"))
                    .setCamisa(new Camisa("Xadrez", "Azul", "Lã", "M"))
                    .setCalca(new Calca("Jeanz", "Preto", "Algodão", 40))
                    .setCalcado(new Calcado("Bota", "Preto", 50))
                    .setArma(new Arma("Chicote", "Marrom", 300, "Full"));
        }
        public void constructFuzileiro(IBuilder builder)
        {
            builder.setCabelo(new Cabelo(3, "Raspado", "Crespo", "Preto"))
                    .setCamisa(new Camisa("Uniforme", "Camuflada", "Nomex", "G"))
                    .setCalca(new Calca("Uniforme", "Camuflada", "Nomex", 45))
                    .setCalcado(new Calcado("Bota", "Camuflada", 45))
                    .setArma(new Arma("Fuzil", "Preto", 100, "Ranged"));
        }
        public void constructLutador(IBuilder builder)
        {
            builder.setCabelo(new Cabelo(25, "Blackpower", "Crespo", "Preto"))
                    .setCamisa(new Camisa("Sem", null, null, null))
                    .setCalca(new Calca("Short", "Branco", "Algodão", 40))
                    .setCalcado(new Calcado("Tenis", "Azul", 45))
                    .setArma(new Arma("Luvas", "Azul", 25, "Melee"));
        }
    }
}
