using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Hadlers
{
    interface IHandler
    {
        public string Livello { get; set; }
        IHandler SetNext(IHandler handler);
        void Approve(double importo);
    }
}
