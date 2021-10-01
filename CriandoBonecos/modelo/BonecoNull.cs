using System;
using System.Collections.Generic;
using System.Text;

namespace ExibiçãoDePedidos.modelo
{
    class BonecoNull : Boneco
    {
        public override Cabelo Cabelo
        {
            get { return new Cabelo(5, "Undercut", "Liso", "Preto"); }
        }
        public override Camisa Camisa
        {
            get { return new Camisa("Terno", "Preto", "Lã", "M"); }
        }
        public override Calca Calca
        {
            get { return new Calca("Calça Social", "Preto", "Lã", 40); }
        }
        public override Calcado Calcado 
        {
            get { return new Calcado("Sapato", "Preto", 45); }
        }

        public override Arma Arma
        {
            get { return new Arma("Revolver", "Cinza", 20, "Ranged"); }
        }
    }
}
