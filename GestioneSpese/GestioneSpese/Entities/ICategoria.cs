using GestioneSpese.GestioneIO;
using GestioneSpese.Hadlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.Entities
{
    public interface ICategoria : IFileManagement
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public bool Approvata { get; set; }
        public string LivelloApprovazione { get; set; }
        public double Importo { get; set; }
        double Rimborso();

    }
}
