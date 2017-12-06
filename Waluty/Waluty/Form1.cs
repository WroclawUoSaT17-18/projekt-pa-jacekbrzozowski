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
    public partial class Form1 : Form
    {
        Double PLN = 1;
        Double Euro = 4.23;
        Double Dolar_Amerykanski = 3.65;
        Double Frank_Szwajcarski = 3.64;
        Double Funt = 4.81;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbWaluty.Text = "Wybierz walute";
            cmbWaluty.Items.Add("Euro");
            cmbWaluty.Items.Add("Funt");
            cmbWaluty.Items.Add("Frank Szwajcarski");
            cmbWaluty.Items.Add("Dolar Amerykanski");
            cmbWaluty.Items.Add("Polski Zloty");

            cmbWaluty2.Text = "Wybierz walute";
            cmbWaluty2.Items.Add("Euro");
            cmbWaluty2.Items.Add("Funt");
            cmbWaluty2.Items.Add("Frank Szwajcarski");
            cmbWaluty2.Items.Add("Dolar Amerykanski");
            cmbWaluty2.Items.Add("Polski Zloty");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double x = Double.Parse(textBox1.Text);
                if (cmbWaluty.Text == "Euro")
                {


                    if (cmbWaluty2.Text == "Euro")
                    {
                        label1.Text = System.Convert.ToString(" 1 Euro");
                    }

                    if (cmbWaluty2.Text == "Funt")
                    {
                        label1.Text = System.Convert.ToString( x*(Euro) / Funt + " GBP");
                    }
                    if (cmbWaluty2.Text == "Frank Szwajcarski")
                    {
                        label1.Text = System.Convert.ToString( x * (Euro) / Frank_Szwajcarski + " CHF");
                    }
                    if (cmbWaluty2.Text == "Dolar Amerykanski")
                    {
                        label1.Text = System.Convert.ToString(x * (Euro) / Dolar_Amerykanski + " USD");
                    }
                    if (cmbWaluty2.Text == "Polski Zloty")
                    {
                        label1.Text = System.Convert.ToString(x * Euro * PLN + " PLN");
                    }
                }

                if (cmbWaluty.Text == "Funt")
                {


                    if (cmbWaluty2.Text == "Euro")
                    {
                        label1.Text = System.Convert.ToString( x*(Funt) / Euro + " Euro");
                    }

                    if (cmbWaluty2.Text == "Funt")
                    {
                        label1.Text = System.Convert.ToString(" 1 GBP");
                    }
                    if (cmbWaluty2.Text == "Frank Szwajcarski")
                    {
                        label1.Text = System.Convert.ToString(x * (Funt) / Frank_Szwajcarski + " CHF");
                    }
                    if (cmbWaluty2.Text == "Dolar Amerykanski")
                    {
                        label1.Text = System.Convert.ToString(x * (Funt) / Dolar_Amerykanski + " USD");
                    }
                    if (cmbWaluty2.Text == "Polski Zloty")
                    {
                        label1.Text = System.Convert.ToString(x * Funt * PLN + " PLN");
                    }

                }

                if (cmbWaluty.Text == "Frank Szwajcarski")
                {


                    if (cmbWaluty2.Text == "Euro")
                    {
                        label1.Text = System.Convert.ToString(x*(Frank_Szwajcarski) / Euro + " Euro");
                    }

                    if (cmbWaluty2.Text == "Funt")
                    {
                        label1.Text = System.Convert.ToString(x * (Frank_Szwajcarski) / Funt + " GBP");
                    }
                    if (cmbWaluty2.Text == "Frank Szwajcarski")
                    {
                        label1.Text = System.Convert.ToString(" 1 CHF");
                    }
                    if (cmbWaluty2.Text == "Dolar Amerykanski")
                    {
                        label1.Text = System.Convert.ToString(x * (Frank_Szwajcarski) / Dolar_Amerykanski + " USD");
                    }
                    if (cmbWaluty2.Text == "Polski Zloty")
                    {
                        label1.Text = System.Convert.ToString(x * Frank_Szwajcarski * PLN + " PLN");
                    }

                }

                if (cmbWaluty.Text == "Dolar Amerykanski")
                {



                    if (cmbWaluty2.Text == "Euro")
                    {
                        label1.Text = System.Convert.ToString(x*(Dolar_Amerykanski) / Euro + " Euro");
                    }

                    if (cmbWaluty2.Text == "Funt")
                    {
                        label1.Text = System.Convert.ToString(x * (Dolar_Amerykanski) / Funt + " GBP");
                    }
                    if (cmbWaluty2.Text == "Frank Szwajcarski")
                    {
                        label1.Text = System.Convert.ToString(x * (Dolar_Amerykanski) / Frank_Szwajcarski + " CHF");
                    }
                    if (cmbWaluty2.Text == "Dolar Amerykanski")
                    {
                        label1.Text = System.Convert.ToString( " 1 USD");
                    }
                    if (cmbWaluty2.Text == "Polski Zloty")
                    {
                        label1.Text = System.Convert.ToString(x * Dolar_Amerykanski * PLN + " PLN");
                    }
                }


                if (cmbWaluty.Text == "Polski Zloty")
                {



                    if (cmbWaluty2.Text == "Euro")
                    {
                        label1.Text = System.Convert.ToString(x / Euro + " Euro");
                    }

                    if (cmbWaluty2.Text == "Funt")
                    {
                        label1.Text = System.Convert.ToString(x / Funt + " GBP");
                    }
                    if (cmbWaluty2.Text == "Frank Szwajcarski")
                    {
                        label1.Text = System.Convert.ToString(x / Frank_Szwajcarski + " CHF");
                    }
                    if (cmbWaluty2.Text == "Dolar Amerykanski")
                    {
                        label1.Text = System.Convert.ToString(x / Dolar_Amerykanski + " USD");
                    }
                    if (cmbWaluty2.Text == "Polski Zloty")
                    {
                        label1.Text = System.Convert.ToString( " 1 PLN");
                    }
                }
            }

            
            catch (Exception Ex)
            {
                MessageBox.Show("Nieobslugiwana wartosc!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
