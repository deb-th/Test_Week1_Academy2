using GestioneSpese.Entities;
using GestioneSpese.Hadlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese
{
    class ChainResponsabilitycs
    {
        public static void Approve(ICategoria spesa)
        {
            var manager = new Manager();
            var OpManager = new OperationalManager();
            var CEO = new CEO();

            //concateno i livelli di approvazione
            manager.SetNext(OpManager).SetNext(CEO);


            List<ICategoria> spese = new List<ICategoria> { };

            //foreach (var import in spese)
            //{

            //    var approve = manager.Handle(import);

            //    if (approve != null)
            //    {
            //        //approvazione
            //    }
            //    else if (import > 2500) 
            //    {
            //        Console.WriteLine($"La spesa non è stata approvata");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"ERRORE");
            //    }
            //}
        }
    }
}