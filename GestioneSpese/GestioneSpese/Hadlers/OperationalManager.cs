using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Hadlers
{
    class OperationalManager : AbstractHandler
    {
        public string Livello { get; set; } = "OperationalManager";
        public override string Handle(double importo)
        {
            if (importo > 400 && importo <= 1000)
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
