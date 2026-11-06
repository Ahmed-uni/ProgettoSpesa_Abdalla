using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoSpesa_Abdalla_Fenaroli
{
    
    public class Prodotto : PictureBox
    {

        protected string nome;
        protected double prezzo;

        public string Nome()
        {
            return nome;
        }

        public void Setnome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Il nome non può essere vuoto");
            this.nome  = nome;
        }
        public double Prezzo()
        {
            return prezzo;
        }

        public void SetPrezzo(double prezzo)
        {
            if (prezzo < 0)
                throw new ArgumentException("Il prezzo non può essere negativo");
            this.prezzo = prezzo;
        }

        public Prodotto(string nome, double prezzo)
        {
            Setnome(nome);
            SetPrezzo(prezzo);

        }
        public virtual string stampa()
        {
            return $"nome: {Nome()}, prezzo: {Prezzo()}";
        } 
    }

        public class Alimentare : Prodotto
        {


            private string scadenza;
            public string Scadenza
            {
                get => scadenza;
                set
                {
                   

                    scadenza = value;
                }
            }

        public Alimentare(string nome, double prezzo, string scadenza)
                : base(nome, prezzo)
            {
                Scadenza = scadenza;
            }
             public override string stampa()
             {
            return $"{base.stampa()}, Scadenza: {Scadenza}";
             }
        }

        
      
        public class Elettronico : Prodotto
        {
        private string durata_garanzia;
            public string Durata_garanzia
        {
            get => durata_garanzia;
            set
            {


                durata_garanzia = value;
            }
        }
        public Elettronico(string nome, double prezzo, string durata_garanzia)
                : base(nome, prezzo)
            {
                Durata_garanzia = durata_garanzia;
            }
            public override string stampa()
            {
                return $"{base.stampa()}, Durata della garanzia {Durata_garanzia}";
            }

        }

    }

