using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waluty
{
    public partial class GlowneOkno : Form
    {
        NBP nbp = new NBP();
        TabelaKursow tabelaKursow;

        public GlowneOkno()
        {
            InitializeComponent();
        }

        private async Task WczytajDaneNBP()
        {
            this.lblWczytywanie.Visible = true;
            string[] notowania = await nbp.PobierzDostepneNotowania();
            this.lblWczytywanie.Visible = false;
            cbNotowania.Items.Clear();
            cbNotowania.Items.AddRange(notowania);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await WczytajDaneNBP();
            cbNotowania.SelectedIndex = 0;
            cbNotowania_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void btnKonwertuj_Click(object sender, EventArgs e)
        {
            double kwota;
            if (!double.TryParse(this.tbPLN.Text, out kwota))
            {
                this.lblWynik.Text = "Nieprawidlowa kwota";
                return;
            }

            PozycjaTabeli pozycjaZ = (PozycjaTabeli)this.cbWalutaZ.SelectedItem;
            double kursZ;
            if (!double.TryParse(pozycjaZ.KursKupna, out kursZ))
            {
                this.lblWynik.Text = "Nie udało się skonwertować na double przelicznik NBP 'Z'";
                return;
            }

            double wartoscPLN = kwota * kursZ;

            PozycjaTabeli pozycjaDo = (PozycjaTabeli)this.cbWalutaDo.SelectedItem;
            double kursDo;
            if (!double.TryParse(pozycjaDo.KursKupna, out kursDo))
            {
                this.lblWynik.Text = "Nie udało się skonwertować na double przelicznik NBP 'Do'";
                return;
            }

            if (kursDo == 0.0)
            {
                this.lblWynik.Text = "Kurs 'Z' to zero1";
                return;
            }

            this.lblWynik.Text = (wartoscPLN * 1.0 / kursDo).ToString();
        }

        private async void cbNotowania_SelectedIndexChanged(object sender, EventArgs e)
        {
            string notowanie = cbNotowania.SelectedItem as string;

            this.lblWczytywanie.Visible = true;
            this.tabelaKursow = await nbp.PobierzTabeleNotowan(notowanie);
            this.lblWczytywanie.Visible = false;

            var pozycje = this.tabelaKursow.Pozycje.Cast<object>().ToArray();

            this.cbWalutaDo.Items.Clear();
            this.cbWalutaDo.Items.AddRange(pozycje);
            this.cbWalutaDo.SelectedIndex = 0;

            this.cbWalutaZ.Items.Clear();
            this.cbWalutaZ.Items.AddRange(pozycje);
            this.cbWalutaZ.SelectedIndex = 0;
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            await WczytajDaneNBP();
        }
    }
}
