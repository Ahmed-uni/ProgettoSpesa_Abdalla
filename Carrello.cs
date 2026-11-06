using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoSpesa_Abdalla_Fenaroli
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class Carrello 
    {
        private List<Prodotto> prodotti;
        private double sconto;
        private int capacitaMassima;
        public Carrello(int capacitaMassima)
        {
            prodotti = new List<Prodotto>();
            sconto = 0;
            this.capacitaMassima = capacitaMassima;
        }

        // con questo metodo aggiungiamo prodotti al carrello
        public void AggiungiProdotto(Prodotto prodotto)
        {
            if (prodotti.Count >= capacitaMassima)
            {
                throw new InvalidOperationException("Il carrello è pieno!"); // in caso il carrello sia pieno, perchè abbiamo messo un limite, allora spunta questa eccezione
            }
            prodotti.Add(prodotto);

        }
        public void ApplicaSconto(double percentualeSconto)
        {
            if (percentualeSconto >= 0 && percentualeSconto <= 100)
            {
                sconto = percentualeSconto;
            }
            else
            {
                throw new ArgumentException("La percentuale di sconto deve essere compresa tra 0 e 100.");
            }
        }

        // metodo per calcolare l'importo dello sconto in valore assoluto
        public double GetImportoSconto()
        {
            double totaleSenzaSconto = prodotti.Sum(p => p.Prezzo()); // calcola il totale senza sconto
            return totaleSenzaSconto * (sconto / 100); // calcola l'importo dello sconto
        }

        public double GetSconto()
        {
            return sconto;
        }

        // metodo per calcolare il totale con sconto
        public double CalcolaTotaleConSconto()
        {
            double totaleSenzaSconto = prodotti.Sum(p => p.Prezzo()); //totale senza sconto
            return totaleSenzaSconto - GetImportoSconto(); // Aapplica lo sconto
        }


        //con questo metodo rimuoviamo il prodotto
        public void RimuoviProdotto(Prodotto prodotto)
        {
            prodotti.Remove(prodotto);
        }
       
        // qui otteniamo  la lista dei prodotti nel carrello
        public List<Prodotto> GetProdotti()
        {
            return prodotti;
        }

        // calcolare il totale della spesa
        public double CalcolaTotale()
        {
            double totale = 0;
            foreach (var prodotto in prodotti)
            {
                totale += prodotto.Prezzo();
            }
            return totale;
        }

        // visualizziamo il contenuto del carrello
        public string VisualizzaCarrello()
        {
            string contenuto = "Carrello:\n";
            foreach (var prodotto in prodotti)
            {
                contenuto += prodotto.ToString() + "\n";
            }
            contenuto += $"Totale: {CalcolaTotale():C}\n";
            return contenuto;
        }
        public int GetCapacitaMassima()
        {
            return capacitaMassima;
        }
    }
}



