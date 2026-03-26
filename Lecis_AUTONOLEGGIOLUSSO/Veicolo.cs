using System;
using System.Collections.Generic;
using System.Text;

namespace Lecis_AUTONOLEGGIOLUSSO
{
    // Usiamo 'public' per rendere la classe accessibile a tutto il progetto.
    // 'abstract' impedisce di creare un veicolo "generico".
    public abstract class Veicolo
    {
        // Proprietà base
        public string Marca { get; set; }
        public string Modello { get; set; }
        public decimal PrezzoGiornaliero { get; set; }
        public string ImmaginePath { get; set; }

        // Costruttore base
        public Veicolo(string marca, string modello, decimal prezzo, string path)
        {
            Marca = marca;
            Modello = modello;
            PrezzoGiornaliero = prezzo;
            ImmaginePath = path;
        }

        // Metodo virtuale: permette alle sottoclassi di personalizzare il calcolo del prezzo (Polimorfismo).
        public virtual decimal CalcolaTotale(int giorni)
        {
            return PrezzoGiornaliero * giorni;
        }
    }
}
