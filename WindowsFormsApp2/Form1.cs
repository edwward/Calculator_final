using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class test : Form
    {
        double cislo;
        string operace;
        Kalkulacka kalkulacka = new Kalkulacka();
        bool operaceNactena;        //bool je defaultne false
        bool jePrvniCislo = true;
        public test()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NastavCislo("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NastavCislo("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NastavCislo("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NastavCislo("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NastavCislo("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NastavCislo("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NastavCislo("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NastavCislo("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NastavCislo("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NastavCislo("9");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            operaceNactena = false;
            jePrvniCislo = true;
            kalkulacka.Vysledek = 0;
            displej.Text = "0";
            label1.Text = "";
        }

        private void buttonDC_Click(object sender, EventArgs e)
        {
            if (!displej.Text.Contains(",")) //pokud displej jiz neobsahuje carku, napis ji
            {
                NastavCislo(",");
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            NactiOperaci("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            NactiOperaci("-");
        }

        private void buttonKrat_Click(object sender, EventArgs e)
        {
            NactiOperaci("*");
        }

        private void buttonDeleno_Click(object sender, EventArgs e)
        {
            NactiOperaci("/");
        }

        private void buttonRovnaSe_Click(object sender, EventArgs e)
        {
            kalkulacka.Vypocitej(operace, cislo);
            displej.Text = kalkulacka.Vysledek.ToString();          //cislo se prevedena string a zobrazi se v textboxu (displeji)
            //reset nahled
            label1.Text = "";
        }

        private void NastavCislo(string vstup)
        {
            if ((displej.Text == "0" && vstup != ",") || operaceNactena)
            {
                displej.Text = vstup;
                operaceNactena = false;
            }
            else
            {
                displej.Text += vstup;      //nacitej na displej dalsi cisla, ktere uziv. chce
            }
            cislo = double.Parse(displej.Text); //nemusim pouzivat try.parse protoze uzivatel nemuze zadat text misto cisel, zada proste vzdy cislo
        }
        private void NactiOperaci(string vstup)
        {
            operace = vstup;
            operaceNactena = true;
            if (jePrvniCislo)
            {
                kalkulacka.Vysledek = cislo;
                label1.Text = cislo + vstup;
                jePrvniCislo = false;
            }
            //zde bude zobrazeni operace
            label1.Text = kalkulacka.Vysledek.ToString() + " " + vstup;
        }

        private void test_KeyPress(object sender, KeyPressEventArgs e)
        {
            buttonRovnaSe.Focus();
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "+":
                    buttonPlus.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "*":
                    buttonKrat.PerformClick();
                    break;
                case "/":
                    buttonDeleno.PerformClick();
                    break;
                case ",":
                    buttonDC.PerformClick();
                    break;
                case "\x1B":        //escape klavesa
                    buttonC.PerformClick();
                    label1.Text = "";
                    break;
                default:
                    break;
            }
        }

    }
}
