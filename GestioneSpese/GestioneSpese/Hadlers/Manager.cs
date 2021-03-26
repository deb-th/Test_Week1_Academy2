using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Hadlers
{
    class Manager : AbstractHandler
    {
        public string Livello { get; set; } = "Manager";
        public override string Handle(double importo)
        {
            if (importo > 0 && importo <= 400)
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
