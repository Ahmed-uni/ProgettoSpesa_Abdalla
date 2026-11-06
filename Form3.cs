using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgettoSpesa_Abdalla_Fenaroli
{
    public partial class Form3 : Form
    {
        private Carrello carrello;
        private Panel panelCarrello; // in questo pannello visualizziamo i prodotti e verra poi successivamente abilitato lo scorrimento della form
        private Panel panelPulsanti; // in questo panel gestiamo invece i pulsanti

        public Form3(Carrello carrello)
        {
            InitializeComponent();
            this.carrello = carrello;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; 
            this.Size = new Size(600, 400); 
            Random random = new Random();
            int scontoCasuale = random.Next(1, 31); // come abbiamo visto in carrello generiamo un numero casuale per lo sconto che fa dal 1 al 31 per cento
            carrello.ApplicaSconto(scontoCasuale);

            InizializzaUI(); // inizializziamo interfaccia per l'utente
            AggiornaCarrello(); // aggiornaimo il carrello 
        }

        private void InizializzaUI()
        {
            panelCarrello = new Panel
            {
                Dock = DockStyle.Fill, 
                AutoScroll = true 
            };
            this.Controls.Add(panelCarrello); 


            panelPulsanti = new Panel
            {
                Size = new Size(this.ClientSize.Width, 100), 
                Dock = DockStyle.Top,
                BackColor = Color.Transparent 
            };
            this.Controls.Add(panelPulsanti); 
            Button buttonChiudi = new Button
            {
                Text = "Chiudi Carrello", 
                Size = new Size(120, 40),  
                Location = new Point(this.ClientSize.Width - 130, 10),
                BackColor = Color.LightGray, 
                Font = new Font("Arial", 10, FontStyle.Bold), 
                Anchor = AnchorStyles.Top | AnchorStyles.Right 
            };

            //evento click per chiudere la form
            buttonChiudi.Click += (sender, e) => this.Close();

            panelPulsanti.Controls.Add(buttonChiudi);



            Button buttonPaga = new Button
            {
                Text = "Paga", 
                Size = new Size(120, 40), 
                Location = new Point(this.ClientSize.Width - 130, 60), 
                BackColor = Color.LightCoral, 
                Font = new Font("Arial", 10, FontStyle.Bold), 
                Anchor = AnchorStyles.Top | AnchorStyles.Right 
            };
            // aggiungiamo l'evento click per chiudere l'intera applicazione
            buttonPaga.Click += (sender, e) =>
            {
                DialogResult risultato = MessageBox.Show("Sei sicuro di voler Pagare ?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  // per verificare la volonte dell'utente per pagare
                if (risultato == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            panelPulsanti.Controls.Add(buttonPaga);
        }



       
        private void AggiornaCarrello()
        {
            panelCarrello.Controls.Clear();

            if (carrello.GetProdotti().Count == 0)
            {
                Label messaggioVuoto = new Label
                {
                    Text = "Il carrello è vuoto.",
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Red
                };
                panelCarrello.Controls.Add(messaggioVuoto);
                return; 
            }

            // raggruppiamo i prodotti in base al tipo
            var prodottiRaggruppati = carrello.GetProdotti()
                .GroupBy(p => p.Nome())
                .ToList();



            //avviene il posizionamento dei prodotti nel panel
            int y = 10; 
            foreach (var gruppo in prodottiRaggruppati)
            {
                Label labelProdotto = new Label
                {
                    Text = gruppo.Key, //nome per ogni prodotto
                    Location = new Point(10, y),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                panelCarrello.Controls.Add(labelProdotto);


                //posizionamento delle picturebox in base al prodotto scelto
                int x = 120; 
                foreach (var prodotto in gruppo)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = prodotto.Image,
                        Size = new Size(50, 50),
                        Location = new Point(x, y),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = prodotto // associazione del prodotto alla picturebox
                    };
                    //evento double click necessario per l'elimnazione dal carrello
                    pictureBox.DoubleClick += PictureBox_DoubleClick;

                    panelCarrello.Controls.Add(pictureBox);
                    x += 60; //spostamento per nuova picturebox in orizz
                }

                y += 70; //spostamento per nuova picturebox in verticale
            }




            Label totaleLabel = new Label
            {
                Text = $"Totale: {carrello.CalcolaTotale():C}",
                Location = new Point(10, y + 20),
                AutoSize = true
            };
            panelCarrello.Controls.Add(totaleLabel);

            Label scontoLabel = new Label
            {
                Text = $"Sconto applicato: {carrello.GetImportoSconto():C} ({carrello.GetSconto()}%)",
                Location = new Point(10, y + 80),
                AutoSize = true,
                ForeColor = Color.Green 
            };
            panelCarrello.Controls.Add(scontoLabel);





            Label totaleScontatoLabel = new Label
            {
                Text = $"Totale scontato: {carrello.CalcolaTotaleConSconto():C}",
                Location = new Point(10, y + 110),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            panelCarrello.Controls.Add(totaleScontatoLabel);


            //vignetta creata per l'utente per elimnare i prodotti
            Label vignetta = new Label
            {
                Text = "Doppio clic su un'immagine per rimuoverla dal carrello.",
                Location = new Point(10, y + 50),
                AutoSize = true,
                Font = new Font("Arial", 9, FontStyle.Italic),
                ForeColor = Color.Gray
            };
            panelCarrello.Controls.Add(vignetta);
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            //"ottenimento " della picturebox cliccata
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox == null) return;

            //"ottenimento " del prodotto cliccato
            Prodotto prodotto = pictureBox.Tag as Prodotto;
            if (prodotto == null) return;

            // rimozione del prodotto dal carrello
            carrello.RimuoviProdotto(prodotto);

//richiamo funzione aggiorna dopo varie eliminazioni etc...
            AggiornaCarrello();
        }
    }
}