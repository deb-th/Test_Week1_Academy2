using GestioneSpese.GestioneIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GestioneSpese.Entities
{
    class Viaggio : CategoriaSpesa
    {
        public override double Rimborso()
        {
            return Importo + 50.0;
        }
    }
}
