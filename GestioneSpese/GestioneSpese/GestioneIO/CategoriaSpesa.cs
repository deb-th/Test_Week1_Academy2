using GestioneSpese.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GestioneSpese.GestioneIO
{
    public abstract class CategoriaSpesa : ICategoria
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public bool Approvata { get; set; }
        public string LivelloApprovazione { get; set; }
        public double Importo { get; set; }
        public abstract double Rimborso();

        public List<ICategoria> ReadFromFile()
        {
            List<ICategoria> listaSpese = new List<ICategoria> { };

            try
            {
                //Lettura da file
                using (StreamReader reader = File.OpenText($"C:\\Users\\deborah.tucci\\Desktop\\Academy Avanade\\Mesi 3 e 4\\Week 1\\Test_Week1\\Spese\\spese.txt"))
                {
                    string dati = reader.ReadLine();

                    //Data;Categoria;Descrizione;Importo
                    string data = reader.ReadLine().Split(';')[0];

                    string[] dataDiv = data.Split('-');

                    Data = new DateTime(Int32.Parse(dataDiv[0]), Int32.Parse(dataDiv[1]), Int32.Parse(dataDiv[2]));

                    string[] spese = reader.ReadLine().Split(';');

                    Categoria = spese[1];

                    Descrizione = spese[2];

                    Importo = Double.Parse(spese[3]);

                    //da implementare in ogni categoria concreta
                    //var spesa = new CategoriaSpesa() { Data, Categoria, Descrizione, False, Importo};

                    //listaSpese.Add(spesa);

                    reader.Close();
                }
                return listaSpese;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"ERRORE IO: {ex.Message}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"ERRORE Generico: {e.Message}");
            }
        }

        public void WriteToFile()
        {
            try
            {
                //Scrittura su file
                using (StreamWriter writer = File.AppendText($"C:\\Users\\deborah.tucci\\Desktop\\Academy Avanade\\Mesi 3 e 4\\Week 1\\Saves\\spese_elaborate.txt"))
                {
                    //Data; Categoria; Descrizione; APPROVATA; LvlApprov; ImportoRimborso
                    //Data; Categoria; Descrizione; RESPINTA; -; -

                    if (Approvata)
                    {
                        //if bool approvata is true
                        writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));

                        string instanceDataAPPR = $"{Data};{Categoria};{Descrizione};APPROVATA;{LivelloApprovazione};{Rimborso()}";

                        writer.WriteLine(instanceDataAPPR);

                        writer.Close();
                    }
                    else
                    {
                        //if bool approvata is false
                        writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));

                        string instanceDataAPPR = $"{Data};{Categoria};{Descrizione};RESPINTA;-;-";

                        writer.WriteLine(instanceDataAPPR);

                        writer.Close();
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"ERRORE IO: {ex.Message}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"ERRORE: {e.Message}");
            }
        }
    }
}
