using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Hadlers
{
    abstract class AbstractHandler : IHandler
    {
        public string Livello { get; set; }

        private IHandler NextHandler;
        public virtual string Handle(double importo)
        {
            if (this.NextHandler != null)
            {
                return this.NextHandler.Handle(importo);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            NextHandler = handler;
            return handler;
        }
    }
}
