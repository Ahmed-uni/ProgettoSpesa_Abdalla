namespace ProgettoSpesa_Abdalla_Fenaroli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CarrelloGrande = new System.Windows.Forms.Button();
            this.CarrelloPiccolo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CarrelloGrande
            // 
            this.CarrelloGrande.BackColor = System.Drawing.Color.Gainsboro;
            this.CarrelloGrande.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CarrelloGrande.BackgroundImage")));
            this.CarrelloGrande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CarrelloGrande.Location = new System.Drawing.Point(146, 124);
            this.CarrelloGrande.Name = "CarrelloGrande";
            this.CarrelloGrande.Size = new System.Drawing.Size(190, 135);
            this.CarrelloGrande.TabIndex = 1;
            this.CarrelloGrande.UseVisualStyleBackColor = false;
            this.CarrelloGrande.Click += new System.EventHandler(this.CarrelloGrande_Click);
            // 
            // CarrelloPiccolo
            // 
            this.CarrelloPiccolo.BackColor = System.Drawing.Color.Gainsboro;
            this.CarrelloPiccolo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CarrelloPiccolo.BackgroundImage")));
            this.CarrelloPiccolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CarrelloPiccolo.Location = new System.Drawing.Point(452, 124);
            this.CarrelloPiccolo.Name = "CarrelloPiccolo";
            this.CarrelloPiccolo.Size = new System.Drawing.Size(190, 135);
            this.CarrelloPiccolo.TabIndex = 2;
            this.CarrelloPiccolo.UseVisualStyleBackColor = false;
            this.CarrelloPiccolo.Click += new System.EventHandler(this.CarrelloPiccolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarrelloPiccolo);
            this.Controls.Add(this.CarrelloGrande);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercato";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CarrelloGrande;
        private System.Windows.Forms.Button CarrelloPiccolo;
    }
}

