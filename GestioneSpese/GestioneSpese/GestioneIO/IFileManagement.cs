using GestioneSpese.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpese.GestioneIO
{
    public interface IFileManagement
    {
        List<ICategoria> ReadFromFile();
        void WriteToFile();
    }
}
