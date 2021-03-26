using GestioneSpese.GestioneIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Entities
{
    class Alloggio : CategoriaSpesa
    {
        public override double Rimborso()
        {
            return Importo;
        }
    }
}
