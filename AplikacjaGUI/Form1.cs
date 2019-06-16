using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace AplikacjaGUI
{
    public partial class OknoGlowne : Form
    {
        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Uruchom_Click(object sender, EventArgs e)
        {
            if (SciezkaTextBox.Text.EndsWith(".txt")) {

                Thread[] t;
                t = new Thread[Convert.ToInt32(LiczbaWatkow.Value)];
                Logger logger = new Logger(Convert.ToInt32(LiczbaDanych.Value), SciezkaTextBox.Text);

                for (int i = 0; i < LiczbaWatkow.Value; i++)
                {
                    t[i] = new Thread(new ThreadStart(logger.Log));
                }

                for (int i = 0; i < LiczbaWatkow.Value; i++)
                {
                    t[i].Start();
                }

                for (int i = 0; i < LiczbaWatkow.Value; i++)
                {
                    t[i].Join(Convert.ToInt32(CzasOczekiwania.Value));
                }

                MessageBox.Show("Wątki zakończyły pracę.\nZapisano do pliku\n" + SciezkaTextBox.Text);
            }
            else
            {
                MessageBox.Show("Podaj poprawną ścieżkę.");
            }
        }

        public int ZwrocLiczneDanych()
        {
            return Convert.ToInt32(LiczbaDanych.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

