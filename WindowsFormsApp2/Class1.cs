using System;
using System.Windows.Forms;

namespace CalcolatriceFrazioni
{
    public class Frazione
    {
        public int Numeratore { get; set; }
        public int Denominatore { get; set; }

        public Frazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        public void Semplifica()
        {
            int mcd = TrovaMCD(Numeratore, Denominatore);
            Numeratore /= mcd;
            Denominatore /= mcd;
        }

        public Frazione Somma(Frazione altraFrazione)
        {
            int nuovoDenominatore = this.Denominatore * altraFrazione.Denominatore;
            int nuovoNumeratore = (this.Numeratore * altraFrazione.Denominatore) + (altraFrazione.Numeratore * this.Denominatore);
            Frazione risultato = new Frazione(nuovoNumeratore, nuovoDenominatore);
            risultato.Semplifica();
            return risultato;
        }

        public Frazione Sottrai(Frazione altraFrazione)
        {
            int nuovoDenominatore = this.Denominatore * altraFrazione.Denominatore;
            int nuovoNumeratore = (this.Numeratore * altraFrazione.Denominatore) - (altraFrazione.Numeratore * this.Denominatore);
            Frazione risultato = new Frazione(nuovoNumeratore, nuovoDenominatore);
            risultato.Semplifica();
            return risultato;
        }

        public Frazione Moltiplica(Frazione altraFrazione)
        {
            int nuovoNumeratore = this.Numeratore * altraFrazione.Numeratore;
            int nuovoDenominatore = this.Denominatore * altraFrazione.Denominatore;
            Frazione risultato = new Frazione(nuovoNumeratore, nuovoDenominatore);
            risultato.Semplifica();
            return risultato;
        }
        public double Valore()
        {
            double valore = (double)Numeratore / Denominatore;
            return valore;
        }

        public Frazione Dividi(Frazione altraFrazione)
        {
            if (altraFrazione.Numeratore != 0)
            {
                int nuovoNumeratore = this.Numeratore * altraFrazione.Denominatore;
                int nuovoDenominatore = this.Denominatore * altraFrazione.Numeratore;
                Frazione risultato = new Frazione(nuovoNumeratore, nuovoDenominatore);
                risultato.Semplifica();
                return risultato;
            }
            else
            {
                throw new InvalidOperationException("Impossibile dividere per zero.");
            }
        }
        public Frazione Potenza(int esponente)
        {
            if (esponente == 0)
            {
                return new Frazione(1, 1); // Qualsiasi frazione elevata a 0 è 1.
            }
            else
            {
                int nuovoNumeratore = (int)Math.Pow(Numeratore, Math.Abs(esponente));
                int nuovoDenominatore = (int)Math.Pow(Denominatore, Math.Abs(esponente));

                if (esponente < 0)
                {
                    int temp = nuovoNumeratore;
                    nuovoNumeratore = nuovoDenominatore;
                    nuovoDenominatore = temp;
                }

                Frazione risultato = new Frazione(nuovoNumeratore, nuovoDenominatore);
                risultato.Semplifica();
               
                return risultato;
            }
        }






        private int TrovaMCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        
    }
}

