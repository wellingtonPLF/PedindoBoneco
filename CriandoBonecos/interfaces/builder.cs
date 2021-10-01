using System;
using System.Collections.Generic;
using System.Text;
using ExibiçãoDePedidos.modelo;

namespace ExibiçãoDePedidos.interfaces
{
    interface IBuilder
    {
        IBuilder setCabelo(Cabelo cabelo);
        IBuilder setCamisa(Camisa camisa);
        IBuilder setCalca(Calca calca);
        IBuilder setCalcado(Calcado calcado);
        IBuilder setArma(Arma arma);
    }
}
