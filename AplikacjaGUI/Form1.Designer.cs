namespace AplikacjaGUI
{
    partial class OknoGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Uruchom = new System.Windows.Forms.Button();
            this.Zamknij = new System.Windows.Forms.Button();
            this.Dane = new System.Windows.Forms.Label();
            this.LWatkow = new System.Windows.Forms.Label();
            this.CzasOczeki = new System.Windows.Forms.Label();
            this.LiczbaDanych = new System.Windows.Forms.NumericUpDown();
            this.LiczbaWatkow = new System.Windows.Forms.NumericUpDown();
            this.CzasOczekiwania = new System.Windows.Forms.NumericUpDown();
            this.SciezkaTextBox = new System.Windows.Forms.TextBox();
            this.Sciezka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LiczbaDanych)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiczbaWatkow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CzasOczekiwania)).BeginInit();
            this.SuspendLayout();
            // 
            // Uruchom
            // 
            this.Uruchom.Location = new System.Drawing.Point(360, 197);
            this.Uruchom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Uruchom.Name = "Uruchom";
            this.Uruchom.Size = new System.Drawing.Size(70, 24);
            this.Uruchom.TabIndex = 0;
            this.Uruchom.Text = "Uruchom";
            this.Uruchom.UseVisualStyleBackColor = true;
            this.Uruchom.Click += new System.EventHandler(this.Uruchom_Click);
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(11, 197);
            this.Zamknij.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(56, 24);
            this.Zamknij.TabIndex = 1;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // Dane
            // 
            this.Dane.AutoSize = true;
            this.Dane.Location = new System.Drawing.Point(109, 33);
            this.Dane.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dane.Name = "Dane";
            this.Dane.Size = new System.Drawing.Size(79, 13);
            this.Dane.TabIndex = 2;
            this.Dane.Text = "Liczba danych:";
            // 
            // LWatkow
            // 
            this.LWatkow.AutoSize = true;
            this.LWatkow.Location = new System.Drawing.Point(109, 63);
            this.LWatkow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LWatkow.Name = "LWatkow";
            this.LWatkow.Size = new System.Drawing.Size(81, 13);
            this.LWatkow.TabIndex = 3;
            this.LWatkow.Text = "Liczba wątków:";
            // 
            // CzasOczeki
            // 
            this.CzasOczeki.AutoSize = true;
            this.CzasOczeki.Location = new System.Drawing.Point(70, 98);
            this.CzasOczeki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CzasOczeki.Name = "CzasOczeki";
            this.CzasOczeki.Size = new System.Drawing.Size(117, 13);
            this.CzasOczeki.TabIndex = 4;
            this.CzasOczeki.Text = "Czas oczekiwania (ms):";
            // 
            // LiczbaDanych
            // 
            this.LiczbaDanych.Location = new System.Drawing.Point(189, 31);
            this.LiczbaDanych.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LiczbaDanych.Name = "LiczbaDanych";
            this.LiczbaDanych.Size = new System.Drawing.Size(142, 20);
            this.LiczbaDanych.TabIndex = 5;
            // 
            // LiczbaWatkow
            // 
            this.LiczbaWatkow.Location = new System.Drawing.Point(189, 61);
            this.LiczbaWatkow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LiczbaWatkow.Name = "LiczbaWatkow";
            this.LiczbaWatkow.Size = new System.Drawing.Size(142, 20);
            this.LiczbaWatkow.TabIndex = 6;
            // 
            // CzasOczekiwania
            // 
            this.CzasOczekiwania.Location = new System.Drawing.Point(189, 95);
            this.CzasOczekiwania.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CzasOczekiwania.Name = "CzasOczekiwania";
            this.CzasOczekiwania.Size = new System.Drawing.Size(142, 20);
            this.CzasOczekiwania.TabIndex = 7;
            // 
            // SciezkaTextBox
            // 
            this.SciezkaTextBox.Location = new System.Drawing.Point(189, 131);
            this.SciezkaTextBox.Name = "SciezkaTextBox";
            this.SciezkaTextBox.Size = new System.Drawing.Size(142, 20);
            this.SciezkaTextBox.TabIndex = 8;
            // 
            // Sciezka
            // 
            this.Sciezka.AutoSize = true;
            this.Sciezka.Location = new System.Drawing.Point(95, 134);
            this.Sciezka.Name = "Sciezka";
            this.Sciezka.Size = new System.Drawing.Size(88, 13);
            this.Sciezka.TabIndex = 9;
            this.Sciezka.Text = "Scieżka do pliku:";
            this.Sciezka.Click += new System.EventHandler(this.label1_Click);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 232);
            this.Controls.Add(this.Sciezka);
            this.Controls.Add(this.SciezkaTextBox);
            this.Controls.Add(this.CzasOczekiwania);
            this.Controls.Add(this.LiczbaWatkow);
            this.Controls.Add(this.LiczbaDanych);
            this.Controls.Add(this.CzasOczeki);
            this.Controls.Add(this.LWatkow);
            this.Controls.Add(this.Dane);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.Uruchom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OknoGlowne";
            this.Text = "Aplikacja wielowątkowa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LiczbaDanych)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiczbaWatkow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CzasOczekiwania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Uruchom;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Label Dane;
        private System.Windows.Forms.Label LWatkow;
        private System.Windows.Forms.Label CzasOczeki;
        private System.Windows.Forms.NumericUpDown LiczbaDanych;
        private System.Windows.Forms.NumericUpDown LiczbaWatkow;
        private System.Windows.Forms.NumericUpDown CzasOczekiwania;
        private System.Windows.Forms.TextBox SciezkaTextBox;
        private System.Windows.Forms.Label Sciezka;
    }
}

