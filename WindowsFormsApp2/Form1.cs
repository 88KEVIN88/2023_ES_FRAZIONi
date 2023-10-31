﻿using CalcolatriceFrazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CalcolaButton_Click(object sender, EventArgs e)
        {
           
        }

        private void CalcolaButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int numeratore1 = int.Parse(textBoxNumeratore1.Text);
                int denominatore1 = int.Parse(textBoxDenominatore1.Text);
                int numeratore2 = int.Parse(textBoxNumeratore2.Text);
                int denominatore2 = int.Parse(textBoxDenominatore2.Text);

                Frazione frazione1 = new Frazione(numeratore1, denominatore1);
                Frazione frazione2 = new Frazione(numeratore2, denominatore2);

                string operazione = textBox1.Text;

                Frazione risultato = null;

                switch (operazione.ToLower())
                {
                    case "somma":
                        risultato = frazione1.Somma(frazione2);
                        break;
                    case "sottrai":
                        risultato = frazione1.Sottrai(frazione2);
                        break;
                    case "moltiplica":
                        risultato = frazione1.Moltiplica(frazione2);
                        break;
                    case "dividi":
                        risultato = frazione1.Dividi(frazione2);
                        break;
                }

                if (risultato != null)
                {
                    risultato.Semplifica();
                    MessageBox.Show($"{risultato.Numeratore}/{risultato.Denominatore}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 
