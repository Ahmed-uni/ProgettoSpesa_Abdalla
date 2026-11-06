using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoSpesa_Abdalla_Fenaroli
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void CarrelloGrande_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(30);



            form2.Show();
        }

        private void CarrelloPiccolo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(15); //15 sta per la capacità che ho assegnato al carrellino, pk è meno capiente del carrello grande 
            form2.Show();
        }
       
    }
}
