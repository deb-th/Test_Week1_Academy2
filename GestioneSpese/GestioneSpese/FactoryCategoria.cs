using GestioneSpese.Entities;
using GestioneSpese.GestioneIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese
{
    public static class FactoryCategoria
    {
        public static ICategoria CreateSpesa(string categoria)
        {
            CategoriaSpesa spesa = null;

            if (categoria == "Viaggio")
            {
                spesa = new Viaggio();

            }
            else if (categoria == "Alloggio")
            {
                spesa = new Alloggio();

            }
            else if (categoria == "Vitto")
            {
                spesa = new Vitto();
            }
            else if (categoria == "Altro")
            {
                spesa = new Altro();
            }
            else
            {
                Console.WriteLine("Incorrect information");
            }
       
            return spesa;
        }
    }
}
