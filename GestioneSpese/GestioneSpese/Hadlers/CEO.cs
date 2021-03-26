using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Hadlers
{
    class CEO : AbstractHandler
    {
        public string Livello { get; set; } = "CEO";
        public override string Handle(double importo)
        {
            if (importo > 1000 && importo <= 2500)
            {
                return "APPROVATA";
            }
            else
            {
                return base.Handle(importo);
            }
        }
    }
}
