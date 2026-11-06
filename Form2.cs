using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ProgettoSpesa_Abdalla_Fenaroli.Prodotto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Media; // questo servirà per aggiungere il tocco musicale

namespace ProgettoSpesa_Abdalla_Fenaroli
{
    public partial class Form2 : Form
    {
        private List<PictureBox> sfondi = new List<PictureBox>(); 
        private int indice_sfondi = 0; 
        private PictureBox currentPictureBox; 
        private Carrello carrello; //abbiamo creato un istanza del carrello, cosi da poter aggiungere i prodotti
        private Form3 form3;
        int capacitaCarrello;
        public Form2(int capacitaCarrello)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.capacitaCarrello = capacitaCarrello;
            // Inizializza il carrello
            carrello = new Carrello(capacitaCarrello);

            sfondi.Add(scaffale1()); //0
            sfondi.Add(scaffale3()); //1
            sfondi.Add(scaffale2());//2
            sfondi.Add(scaffale());//3
            sfondi.Add(scaffale5());//4
            sfondi.Add(scaffale4());//5

            currentPictureBox = sfondi[0]; // parte da scaffale verdure con indice 0
            this.Controls.Add(currentPictureBox);

            button1.Enabled = false; //  ha senso perchè puoi andare solo avanti all'inizio
            button2.Enabled = true; 

            this.Resize += Form2_Resize;

            this.Load += Form2_Load;

            // Aggiungi un pulsante per aprire il carrello






        }



        private void Form2_Load(object sender, EventArgs e)
        {
            //verdura
            // Verdure
            List<Alimentare> pomodoro = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsP = new List<System.Windows.Forms.ToolTip>();
            Elemento(pomodoro, tooltipsP, 4, "Pomodoro", 0.50, "Tra 3 giorni", @"immaginiVerdure\pomodoro.png", 140, 150, currentPictureBox);

            List<Alimentare> carota = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsC = new List<System.Windows.Forms.ToolTip>();
            Elemento(carota, tooltipsC, 4, "Carota", 0.46, "Tra 6 giorni", @"immaginiVerdure\carota.png", 230, 150, currentPictureBox);

            List<Alimentare> zucchine = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsZ = new List<System.Windows.Forms.ToolTip>();
            Elemento(zucchine, tooltipsZ, 4, "Zucchine", 0.67, "Tra 4 giorni", @"immaginiVerdure\zucchina.png", 320, 150, currentPictureBox);

            List<Alimentare> cavolo = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsCA = new List<System.Windows.Forms.ToolTip>();
            Elemento(cavolo, tooltipsCA, 4, "Cavolo", 0.78, "Tra 4 giorni", @"immaginiVerdure\cavolo.png", 410, 150, currentPictureBox);

            List<Alimentare> lattuga = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsL = new List<System.Windows.Forms.ToolTip>();
            Elemento(lattuga, tooltipsL, 4, "Lattuga", 0.50, "Tra 8 giorni", @"immaginiVerdure\lattuga.png", 490, 150, currentPictureBox);

            //---------------------------------------------------------------------------------------------

            // Frutta
            List<Alimentare> fragole = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsF = new List<System.Windows.Forms.ToolTip>();
            Elemento(fragole, tooltipsF, 4, "Fragole", 0.50, "Tra 6 giorni", @"immaginiFrutta\fragola.png", 175, 500, currentPictureBox);

            List<Alimentare> mela = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsM = new List<System.Windows.Forms.ToolTip>();
            Elemento(mela, tooltipsM, 4, "Mela", 0.35, "Tra 9 giorni", @"immaginiFrutta\mela.png", 250, 500, currentPictureBox);

            List<Alimentare> banana = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsB = new List<System.Windows.Forms.ToolTip>();
            Elemento(banana, tooltipsB, 4, "Banana", 0.90, "Tra 4.5 giorni", @"immaginiFrutta\banana.png", 320, 500, currentPictureBox);

            List<Alimentare> uva = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsU = new List<System.Windows.Forms.ToolTip>();
            Elemento(uva, tooltipsU, 4, "Uva", 0.89, "Tra 3.5 giorni", @"immaginiFrutta\uva.png", 390, 500, currentPictureBox);

            //-------------------------------------------------------------------------------
            // Misto tra frutta e verdura
            List<Alimentare> cipolla = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsCipolla = new List<System.Windows.Forms.ToolTip>();
            Elemento(cipolla, tooltipsCipolla, 4, "Cipolla", 0.59, "Tra 6.5 giorni", @"FruttaVerduraMiste\cipolla.png", 100, 800, currentPictureBox);

            List<Alimentare> pera = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsPera = new List<System.Windows.Forms.ToolTip>();
            Elemento(pera, tooltipsPera, 4, "Pera", 0.59, "Tra 9.5 giorni", @"FruttaVerduraMiste\pera.png", 310, 800, currentPictureBox);

            List<Alimentare> zucca = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsZucca = new List<System.Windows.Forms.ToolTip>();
            Elemento(zucca, tooltipsZucca, 4, "Zucca", 0.59, "Tra 11 giorni", @"FruttaVerduraMiste\zucca.png", 175, 800, currentPictureBox);

            //-------------------------------------------------------------------------------------

            // Pasta
            List<Alimentare> rigatoni = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsRigatoni = new List<System.Windows.Forms.ToolTip>();
            Elemento(rigatoni, tooltipsRigatoni, 4, "Pasta : Rigatoni", 2.40, "Tra 60 giorni", @"immaginiPasta\rigatoni.png", 100, 150, sfondi[2]);

            List<Alimentare> farfalle = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsFarfalle = new List<System.Windows.Forms.ToolTip>();
            Elemento(farfalle, tooltipsFarfalle, 4, "Pasta : Farfalle", 2.00, "Tra 60 giorni", @"immaginiPasta\farfalle.png", 250, 150, sfondi[2]);

            List<Alimentare> pennette = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsPennette = new List<System.Windows.Forms.ToolTip>();
            Elemento(pennette, tooltipsPennette, 4, "Pasta : Pennette", 1.90, "Tra 60 giorni", @"immaginiPasta\pennette.png", 320, 150, sfondi[2]);

            List<Alimentare> spaghetti = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsSpaghetti = new List<System.Windows.Forms.ToolTip>();
            Elemento(spaghetti, tooltipsSpaghetti, 4, "Pasta : Spaghetti", 3.00, "Tra 50 giorni", @"immaginiPasta\spaghetti.png", 400, 150, sfondi[2]);

            // Riso e farine
            //--------------------------------------------------------------------------------------------
            List<Alimentare> farina0 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsFarina0 = new List<System.Windows.Forms.ToolTip>();
            Elemento(farina0, tooltipsFarina0, 4, "Farina 0", 2.89, "Tra 60 giorni", @"immaginiRisoFarina\farina0.png", 50, 600, sfondi[2]);

            List<Alimentare> farina00 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsFarina00 = new List<System.Windows.Forms.ToolTip>();
            Elemento(farina00, tooltipsFarina00, 4, "Farina 00", 2.89, "Tra 60 giorni", @"immaginiRisoFarina\farina00.png", 150, 600, sfondi[2]);

            List<Alimentare> risoBasmati = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsrisoBasmati = new List<System.Windows.Forms.ToolTip>();
            Elemento(risoBasmati, tooltipsrisoBasmati, 4, "Riso : Basmati", 3.14, "Tra 80 giorni", @"immaginiRisoFarina\risobasmati.png", 200, 600, sfondi[2]);

            List<Alimentare> risoIntegrale = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsrisoIntegrale = new List<System.Windows.Forms.ToolTip>();
            Elemento(risoIntegrale, tooltipsrisoIntegrale, 4, "Riso : Integrale", 4.00, "Tra 80 giorni", @"immaginiRisoFarina\risointegrale.png", 290, 600, sfondi[2]);

            List<Alimentare> risoVenere = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsrisoVenere = new List<System.Windows.Forms.ToolTip>();
            Elemento(risoVenere, tooltipsrisoVenere, 4, "Riso : Venere", 3.50, "Tra 90 giorni", @"immaginiRisoFarina\risovenere.png", 400, 600, sfondi[2]);

            //--------------------------------------------------------------------------------------------------------------

            // Biscotti
            List<Alimentare> galletti = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsgalletti = new List<System.Windows.Forms.ToolTip>();
            Elemento(galletti, tooltipsgalletti, 4, "Biscotti : Galletti", 3.50, "Tra 120 giorni", @"immaginiBiscotti\galletti.png", 50, 100, sfondi[3]);

            List<Alimentare> gocciole = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsgocciole = new List<System.Windows.Forms.ToolTip>();
            Elemento(gocciole, tooltipsgocciole, 4, "Biscotti : Gocciole", 5.00, "Tra 120 giorni", @"immaginiBiscotti\gocciole.png", 170, 100, sfondi[3]);

            List<Alimentare> nascondini = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsnascondini = new List<System.Windows.Forms.ToolTip>();
            Elemento(nascondini, tooltipsnascondini, 4, "Biscotti : Nascondini", 2.50, "Tra 122 giorni", @"immaginiBiscotti\nascondini.png", 300, 100, sfondi[3]);

            List<Alimentare> ritornelli = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsritornelli = new List<System.Windows.Forms.ToolTip>();
            Elemento(ritornelli, tooltipsritornelli, 4, "Biscotti : Ritornelli", 2.70, "Tra 125 giorni", @"immaginiBiscotti\ritornelli.png", 400, 100, sfondi[3]);

            //-----------------------------------------------------------------------------------------------------------------------------------
            // Merendine
            List<Alimentare> cioccolato = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipscioccolato = new List<System.Windows.Forms.ToolTip>();
            Elemento(cioccolato, tooltipscioccolato, 4, "Cioccolato al latte", 2.00, "Tra 136 giorni", @"immaginiBiscotti\cioccolato.png", 50, 600, sfondi[3]);

            List<Alimentare> merendina3 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsmerendina3 = new List<System.Windows.Forms.ToolTip>();
            Elemento(merendina3, tooltipsmerendina3, 4, "Ferrero : Nutella", 5.37, "Tra 166 giorni", @"immaginiBiscotti\merendina3.png", 150, 600, sfondi[3]);

            List<Alimentare> merendina2 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsmerendina2 = new List<System.Windows.Forms.ToolTip>();
            Elemento(merendina2, tooltipsmerendina2, 4, "Merendina : Buondì", 3.79, "Tra 208 giorni", @"immaginiBiscotti\merendina2.png", 300, 600, sfondi[3]);

            List<Alimentare> merendina1 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsmerendina1 = new List<System.Windows.Forms.ToolTip>();
            Elemento(merendina1, tooltipsmerendina1, 4, "Kinder : Brioss", 6.50, "Tra 199 giorni", @"immaginiBiscotti\merendina1.png", 420, 600, sfondi[3]);

            //-----------------------------------------------------------------------------------------------
            // Carne e pesce
            List<Alimentare> carne1 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipscarne1 = new List<System.Windows.Forms.ToolTip>();
            Elemento(carne1, tooltipscarne1, 4, "Lombata di bovino", 7.50, "Tra 40 giorni", @"immaginiCarne\carne1.png", 50, 100, sfondi[1]);

            List<Alimentare> carne2 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipscarne2 = new List<System.Windows.Forms.ToolTip>();
            Elemento(carne2, tooltipscarne2, 4, "Carpaccio di bovino", 6.50, "Tra 38 giorni", @"immaginiCarne\carne2.png", 170, 100, sfondi[1]);

            List<Alimentare> carne3 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipscarne3 = new List<System.Windows.Forms.ToolTip>();
            Elemento(carne3, tooltipscarne3, 4, "Salsiccia", 5.60, "Tra 35 giorni", @"immaginiCarne\carne3.png", 300, 100, sfondi[1]);

            List<Alimentare> carne4 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipscarne4 = new List<System.Windows.Forms.ToolTip>();
            Elemento(carne4, tooltipscarne4, 4, "Prosciutto crudo", 2.50, "Tra 30 giorni", @"immaginiCarne\carne4.png", 400, 100, sfondi[1]);

            //-----------------------------------------------------------------------------------------------
            List<Alimentare> pesce1 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipspesce1 = new List<System.Windows.Forms.ToolTip>();
            Elemento(pesce1, tooltipspesce1, 4, "Salmone affumicato", 7.50, "Tra 20 giorni", @"immaginePesce\pesce1.png", 50, 700, sfondi[1]);

            List<Alimentare> pesce2 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipspesce2 = new List<System.Windows.Forms.ToolTip>();
            Elemento(pesce2, tooltipspesce2, 4, "Branzino", 6.35, "Tra 18 giorni", @"immaginePesce\pesce2.png", 170, 700, sfondi[1]);

            List<Alimentare> pesce3 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipspesce3 = new List<System.Windows.Forms.ToolTip>();
            Elemento(pesce3, tooltipspesce3, 4, "Filetti di merluzzo", 5.35, "Tra 19 giorni", @"immaginePesce\pesce3.jpg", 300, 700, sfondi[1]);

            List<Alimentare> pesce4 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipspesce43 = new List<System.Windows.Forms.ToolTip>();
            Elemento(pesce4, tooltipspesce43, 4, "Filetti di salmone", 6.20, "Tra 24 giorni", @"immaginePesce\pesce4.png", 400, 700, sfondi[1]);

            //--------------------------------------------------------------------------------------------------------------------------------
            // Liquidi
            List<Alimentare> acqua1x6 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsacqua1x6 = new List<System.Windows.Forms.ToolTip>();
            Elemento(acqua1x6, tooltipsacqua1x6, 3, "Acqua Sant'Anna X 6", 3.60, "Tra 200 giorni", @"immaginiLiquidi\acqua1x6.png", 50, 100, sfondi[4]);

            List<Alimentare> acqua2x6 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsacqua2x6 = new List<System.Windows.Forms.ToolTip>();
            Elemento(acqua2x6, tooltipsacqua2x6, 3, "Acqua Rocchetta X 6", 3.40, "Tra 202 giorni", @"immaginiLiquidi\acqua2x6.png", 200, 100, sfondi[4]);

            List<Alimentare> acqua3x6 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsacqua3x6 = new List<System.Windows.Forms.ToolTip>();
            Elemento(acqua3x6, tooltipsacqua3x6, 3, "Acqua Lete X 6", 3.50, "Tra 203 giorni", @"immaginiLiquidi\acqua3x6.png", 320, 100, sfondi[4]);

            // Altri liquidi
            List<Alimentare> altroliquido1 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsaltroliquido1 = new List<System.Windows.Forms.ToolTip>();
            Elemento(altroliquido1, tooltipsaltroliquido1, 3, "Coca Cola X 6", 5.50, "Tra 189 giorni", @"immaginiLiquidi\altriliquidi1.png", 200, 700, sfondi[4]);

            List<Alimentare> altroliquido2 = new List<Alimentare>();
            List<System.Windows.Forms.ToolTip> tooltipsaltroliquido2 = new List<System.Windows.Forms.ToolTip>();
            Elemento(altroliquido2, tooltipsaltroliquido2, 3, "Succhi Yoga X 6", 4.80, "Tra 267 giorni", @"immaginiLiquidi\altriliquidi2.png", 330, 700, sfondi[4]);

            //-----------------------------------------------------------------------------------------------------------------------
            // Elettronica 1
            List<Elettronico> elettronico1 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico1 = new List<System.Windows.Forms.ToolTip>();
            Elettronico1(elettronico1, tooltipselettronico1, 2, "Iphone 16", 789, "Garanzia valida fino al 18 aprile 2027", @"immaginiElettronica\elettronico1.png", 30, sfondi[5]);

            List<Elettronico> elettronico2 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico2 = new List<System.Windows.Forms.ToolTip>();
            Elettronico1(elettronico2, tooltipselettronico2, 2, "Samsung S24 ultra", 1345, "Garanzia valida fino al 5 maggio 2026", @"immaginiElettronica\elettronico2.png", 150, sfondi[5]);

            List<Elettronico> elettronico3 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico3 = new List<System.Windows.Forms.ToolTip>();
            Elettronico1(elettronico3, tooltipselettronico3, 2, "Lenovo Pad s6", 210.46, "Garanzia valida fino al 19 novembre 2025", @"immaginiElettronica\elettronico3.png", 280, sfondi[5]);

            List<Elettronico> elettronico4 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico4 = new List<System.Windows.Forms.ToolTip>();
            Elettronico1(elettronico4, tooltipselettronico4, 2, "HP pc Windows Book", 415.99, "Garanzia valida fino al 3 agosto 2028", @"immaginiElettronica\elettronico4.png", 380, sfondi[5]);

            //-----------------------------------------------------------------------------------------------------------------------
            // Elettronica 2
            List<Elettronico> elettronico21 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico21 = new List<System.Windows.Forms.ToolTip>();
            Elettronico2(elettronico21, tooltipselettronico21, 2, "Stampante Epson", 210.50, "Garanzia valida fino al 31 dicembre 2026", @"immaginiElettronica\elettronico21.png", 30, sfondi[5]);

            List<Elettronico> elettronico22 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico22 = new List<System.Windows.Forms.ToolTip>();
            Elettronico2(elettronico22, tooltipselettronico22, 2, "Monitor Gaming curvo oled", 369.99, "Garanzia valida fino al 3 giugno 2027", @"immaginiElettronica\elettronico22.png", 150, sfondi[5]);

            List<Elettronico> elettronico23 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico23 = new List<System.Windows.Forms.ToolTip>();
            Elettronico2(elettronico23, tooltipselettronico23, 2, "Cuffie bluetooth", 45.99, "Garanzia valida fino al 7 luglio 2028", @"immaginiElettronica\elettronico23.png", 280, sfondi[5]);

            List<Elettronico> elettronico24 = new List<Elettronico>();
            List<System.Windows.Forms.ToolTip> tooltipselettronico24 = new List<System.Windows.Forms.ToolTip>();
            Elettronico2(elettronico24, tooltipselettronico24, 2, "Playstation5 con GamePad", 599.99, "Garanzia valida fino al 7 settembre 2027", @"immaginiElettronica\elettronico24.png", 380, sfondi[5]);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            foreach (var pictureBox in sfondi)
            {
                pictureBox.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 55); 
                pictureBox.Location = new Point(0, 55);
            }
        }

        public PictureBox scaffale1()
        {
            PictureBox scaffale1 = new PictureBox();
            scaffale1.Size = new Size(1550, 800); 
            scaffale1.Location = new Point(0, 55); 
            scaffale1.Image = Image.FromFile("scaffale_verdura.jpg"); 
            scaffale1.SizeMode = PictureBoxSizeMode.StretchImage; 
            scaffale1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return scaffale1;
        }

        public PictureBox scaffale()
        {
            PictureBox scaffale = new PictureBox();
            scaffale.Size = new Size(1550, 800); 
            scaffale.Location = new Point(0, 55); 
            scaffale.Image = Image.FromFile("5900594_3736.jpg"); 
            scaffale.SizeMode = PictureBoxSizeMode.StretchImage; 
            scaffale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return scaffale;
        }

        public PictureBox scaffale2()
        {
            PictureBox scaffale2 = new PictureBox();
            scaffale2.Size = new Size(1550, 800); 
            scaffale2.Location = new Point(0, 55); 
            scaffale2.Image = Image.FromFile("5900594_3736.jpg"); 
            scaffale2.SizeMode = PictureBoxSizeMode.StretchImage; 
            scaffale2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return scaffale2;
        }

        public PictureBox scaffale3()
        {
            PictureBox scaffale1 = new PictureBox();
            scaffale1.Size = new Size(1550, 800); 
            scaffale1.Location = new Point(0, 55); 
            scaffale1.Image = Image.FromFile("bancofrigo.jpg"); 
            scaffale1.SizeMode = PictureBoxSizeMode.StretchImage; 
            scaffale1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return scaffale1;
        }

        public PictureBox scaffale4()
        {
            PictureBox scaffale4 = new PictureBox();
            scaffale4.Size = new Size(1550, 800); 
            scaffale4.Location = new Point(0, 55); 
            scaffale4.Image = Image.FromFile("scaffale elettronica.jpg"); 
            scaffale4.SizeMode = PictureBoxSizeMode.StretchImage; 
            scaffale4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return scaffale4;
        }

        public PictureBox scaffale5()
        {
            PictureBox scaffale2 = new PictureBox();
            scaffale2.Size = new Size(1550, 800); 
            scaffale2.Location = new Point(0, 55); 
            scaffale2.Image = Image.FromFile("5900594_3736.jpg"); 
            scaffale2.SizeMode = PictureBoxSizeMode.StretchImage; 
            scaffale2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return scaffale2;
        }

        //piazzamneto verdura
        private void Elemento(List<Alimentare> oggetto, List<System.Windows.Forms.ToolTip> toolTips, int ElementoRappresentativa, string Nome, double Prezzo, string Scadenza, string Percorso, int Altezza, int larghezza, PictureBox sfondo)
        {
            Random random = new Random();
            int quantitaElemento = random.Next(20, 79); // numero randoms di elementi da 20 a 79
            ElementoRappresentativa = 4; 

            //qui inizializziamo le liste
            if (oggetto == null) oggetto = new List<Alimentare>();
            if (toolTips == null) toolTips = new List<System.Windows.Forms.ToolTip>();

            for (int i = 0; i < ElementoRappresentativa; i++)
            {
                try
                {
                    // crea un nuovo prodotto e lo aggiunge alla lista
                    Alimentare prodotto = new Alimentare(Nome, Prezzo, Scadenza);
                    oggetto.Add(prodotto);

                    // crea un nuovo tooltip e lo aggiunge alla lista
                    System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                    toolTips.Add(toolTip);

                    // qui configuiriamo i valori della picturebox da stampare
                    prodotto.Size = new Size(75, 75);
                    prodotto.Image = Image.FromFile(Percorso);
                    prodotto.BackColor = Color.Transparent;
                    prodotto.SizeMode = PictureBoxSizeMode.StretchImage;
                    prodotto.Location = new Point(larghezza + i * 75, Altezza);
                    prodotto.Parent = sfondo;
                    prodotto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;

                    toolTip.SetToolTip(prodotto, prodotto.stampa() + $"\nQuantità: {quantitaElemento}");

                    // gestione della pressione sulla picturebox prodotto
                    prodotto.Click += (sender, e) =>
                    {
                        try
                        {
                            if (quantitaElemento > 0)
                            {
                                quantitaElemento--;
                                carrello.AggiungiProdotto(prodotto); // aggiungiamo al carrello se schiacciata
                                SoundPlayer player = new SoundPlayer("rumoresoldi.wav");
                                player.Play();
                                // Aggiorna i tooltip
                                for (int j = 0; j < oggetto.Count; j++)
                                {
                                    toolTips[j].SetToolTip(oggetto[j], oggetto[j].stampa() + $"\nQuantità: {quantitaElemento}");
                                }

                                // se il prodotto con numero randoms arriva a0 allora facciamo un dispsoe cosi eliminiamo realisticamente il prodotto
                                if (quantitaElemento == 0)
                                {
                                    for (int j = 0; j < oggetto.Count; j++)
                                    {
                                        oggetto[j].Dispose();
                                    }
                                }
                            }
                        }
                        catch (InvalidOperationException ex)
                        {
                            // quando il carrello è pieno viene visualizzato un messaggio di "pericolo"
                            MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Errore durante l'aggiunta del prodotto: {ex.Message}");
                        }
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'inizializzazione del prodotto: {ex.Message}");
                }
            }
        }


        //ELETTRONICA
        private void Elettronico1(List<Elettronico> Elettronico, List<System.Windows.Forms.ToolTip> toolTips, int Elettronico1Rappresentativa, string Nome, double Prezzo, string durata_garanzia, string Percorso, int Altezza, PictureBox scaffaleCorrente)
        {
            Random random = new Random();
            int quantitaElettronico1 = random.Next(10, 23); 
            Elettronico1Rappresentativa = 2; 

            if (Elettronico == null) Elettronico = new List<Elettronico>();
            if (toolTips == null) toolTips = new List<System.Windows.Forms.ToolTip>();

            for (int i = 0; i < Elettronico1Rappresentativa; i++)
            {
                try
                {
                    Elettronico prodotto = new Elettronico(Nome, Prezzo, durata_garanzia);
                    Elettronico.Add(prodotto);

                    System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                    toolTips.Add(toolTip);

                    prodotto.Size = new Size(120, 120);
                    prodotto.Image = Image.FromFile(Percorso);
                    prodotto.BackColor = Color.Transparent;
                    prodotto.SizeMode = PictureBoxSizeMode.StretchImage;
                    prodotto.Location = new Point(350 + i * 120, Altezza);
                    prodotto.Parent = scaffaleCorrente;
                    prodotto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;

                    toolTip.SetToolTip(prodotto, prodotto.stampa() + $"\nQuantità: {quantitaElettronico1}");

                    prodotto.Click += (sender, e) =>
                    {
                        try
                        {
                            if (quantitaElettronico1 > 0)
                            {
                                quantitaElettronico1--;
                                carrello.AggiungiProdotto(prodotto); 
                                SoundPlayer player = new SoundPlayer("rumoresoldi.wav");
                                player.Play();

                                //qua aggiornaimo i tool tip ogni volta che vengono pigiati
                                for (int j = 0; j < Elettronico.Count; j++)
                                {
                                    toolTips[j].SetToolTip(Elettronico[j], Elettronico[j].stampa() + $"\nQuantità: {quantitaElettronico1}");
                                }

                                if (quantitaElettronico1 == 0)
                                {
                                    for (int j = 0; j < Elettronico.Count; j++)
                                    {
                                        Elettronico[j].Dispose();
                                    }
                                }
                            }
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Errore durante l'aggiunta del prodotto: {ex.Message}");
                        }
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'inizializzazione del prodotto: {ex.Message}");
                }
            }
        }
        private void Elettronico2(List<Elettronico> Elettronico, List<System.Windows.Forms.ToolTip> toolTips, int Elettronico2Rappresentativa, string Nome, double Prezzo, string durata_garanzia, string Percorso, int Altezza, PictureBox scaffaleCorrente)
        {
            Random random = new Random();
            int quantitaElettronico2 = random.Next(10, 23); 
            Elettronico2Rappresentativa = 2; 

            if (Elettronico == null) Elettronico = new List<Elettronico>();
            if (toolTips == null) toolTips = new List<System.Windows.Forms.ToolTip>();

            for (int i = 0; i < Elettronico2Rappresentativa; i++)
            {
                try
                {
                    Elettronico prodotto = new Elettronico(Nome, Prezzo, durata_garanzia);
                    Elettronico.Add(prodotto);

                    System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                    toolTips.Add(toolTip);

                    prodotto.Size = new Size(120, 120);
                    prodotto.Image = Image.FromFile(Percorso);
                    prodotto.BackColor = Color.Transparent;
                    prodotto.SizeMode = PictureBoxSizeMode.StretchImage;
                    prodotto.Location = new Point(700 + i * 120, Altezza);
                    prodotto.Parent = scaffaleCorrente;
                    prodotto.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

                    toolTip.SetToolTip(prodotto, prodotto.stampa() + $"\nQuantità: {quantitaElettronico2}");

                    prodotto.Click += (sender, e) =>
                    {
                        try
                        {
                            if (quantitaElettronico2 > 0)
                            {
                                quantitaElettronico2--;
                                carrello.AggiungiProdotto(prodotto); 
                                SoundPlayer player = new SoundPlayer("rumoresoldi.wav");
                                player.Play();
                                for (int j = 0; j < Elettronico.Count; j++)
                                {
                                    toolTips[j].SetToolTip(Elettronico[j], Elettronico[j].stampa() + $"\nQuantità: {quantitaElettronico2}");
                                }

                                if (quantitaElettronico2 == 0)
                                {
                                    for (int j = 0; j < Elettronico.Count; j++)
                                    {
                                        Elettronico[j].Dispose();
                                    }
                                }
                            }
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Errore durante l'aggiunta del prodotto: {ex.Message}");
                        }
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'inizializzazione del prodotto: {ex.Message}");
                }
            }
        }

        //adesso passiamo ai liquidi

        private void button1_Click(object sender, EventArgs e)
        {
            // verifichiamo di trovarci nel primo scaffale
            if (indice_sfondi > 0)
            {
                this.Controls.Remove(currentPictureBox);
                indice_sfondi--; 
                currentPictureBox = sfondi[indice_sfondi];
                this.Controls.Add(currentPictureBox);
            }

            button1.Enabled = indice_sfondi > 0;

            button2.Enabled = indice_sfondi < sfondi.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indice_sfondi < sfondi.Count - 1)
            {
                this.Controls.Remove(currentPictureBox);
                indice_sfondi++; 
                currentPictureBox = sfondi[indice_sfondi];
                this.Controls.Add(currentPictureBox);
            }

            button2.Enabled = indice_sfondi < sfondi.Count - 1;

            button1.Enabled = indice_sfondi > 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new Form3(carrello);
                form3.Show();
            }
            else
            {
                form3.BringToFront(); // con bring to front portiamo la finestra, in questo caso form3 in primo piano
            }
        }

    }
}
