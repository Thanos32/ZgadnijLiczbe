using System;
using System.Windows.Forms;
using System.IO;

namespace ZgadnijLiczbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int RandomNumber;
        int liczba;
        int licznik = 0;
        int rekord = 100000000;
        double srednia = 0;
        int ileProb = 0;
        Random rnd = new Random();
        string[] lines;
        int randomLineNumber;
        string line { get; set; }
        string NoweSlowo { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomNumber = rnd.Next(999) + 1;
            lines = File.ReadAllLines("slowa.txt");
            GenerujNoweSlowo();
        }

        private void LiczbaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LiczbaOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void LiczbaInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ZgadnijBtn_Click(this, new EventArgs());
            }
        }

        private void SlowoInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ZgadnijBtn2_Click(this, new EventArgs());
            }
        }

        private void ZgadnijBtn_Click(object sender, EventArgs e)
        {
            

            if (this.LiczbaInput.Text == "")
            {
                MessageBox.Show("Podaj prawidłową liczbę.");
                return;
            }
            try
            {
                liczba = Convert.ToInt32(this.LiczbaInput.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Błąd: " + exc.Message + "\r\nPodaj prawidłową liczbę.");
                this.LiczbaInput.Clear();
                return;
            }
            if (liczba > 999 || liczba < 1)
            {
                MessageBox.Show("Twoja liczba nie mieści się w przedziale od 1 do 999");
                this.LiczbaInput.Clear();
                return;
            }
            

            licznik++;
            this.LiczbaProb.Text = Convert.ToString(licznik);

            this.LiczbaInput.Clear();
            this.LiczbaOutput.Text = $"Wpisana liczba: {liczba} \r\n";
            if (liczba < RandomNumber)
            {
                this.LiczbaOutput.Text += "Twoja liczba jest mniejsza od szukanej. Spóbuj ponownie.";
            }
            else if (liczba > RandomNumber)
            {
                this.LiczbaOutput.Text += "Twoja liczba jest większa od szukanej. Spóbuj ponownie.";
            }
            else if (liczba == RandomNumber)
            {
                this.LiczbaOutput.Text += "Gratulacje, odgadłeś liczbę! Aby zagrać znowu, wpisz kolejną liczbę.";
                if (licznik < rekord)
                {
                    this.Rekord.Text = Convert.ToString(licznik);
                }

                srednia = (srednia * ileProb + licznik) / (ileProb + 1);
                Srednia.Text = Convert.ToString(srednia);
                ileProb++;
                licznik = 0;
                RandomNumber = rnd.Next(999) + 1;
            }



        }





        private void SlowoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZgadnijBtn2_Click(object sender, EventArgs e)
        {
            string slowo = this.SlowoInput.Text;
            slowo = slowo.Trim();
            this.OstatnieSlowo.Text = slowo;
            this.SlowoInput.Clear();

            
            if (slowo.Length != line.Length)
            {
                MessageBox.Show("Podałeś niewłaściwą długość słowa.");
                this.SlowoInput.Clear();
                return;
            }

            for (int i = 0; i < line.Length; i++)
            {
                if (slowo[i] == line[i])
                {
                    string str = NoweSlowo;
                    str = str.Remove(i, 1);
                    str = str.Insert(i, line[i].ToString());
                    NoweSlowo = str;
                }
            }
            this.SlowoOutput.Text = NoweSlowo;
            if (NoweSlowo == line)
            {
                this.SlowoOutput.Text = "Gratualcje! Odgadłeś słowo: " + line;
                GenerujNoweSlowo();
                this.SlowoInput.Clear();
            }
        }

        private void zresetujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                licznik = 0;
                this.LiczbaProb.Clear();
                this.LiczbaInput.Clear();
                this.LiczbaOutput.Clear();
                RandomNumber = rnd.Next(999) + 1;
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                this.SlowoInput.Clear();
                this.SlowoOutput.Clear();
                this.OstatnieSlowo.Clear();
                GenerujNoweSlowo();
            }
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void GenerujNoweSlowo()
        {
            do
            {
                randomLineNumber = rnd.Next(0, lines.Length - 1);
                line = lines[randomLineNumber];

            } while (line.Length >= 10);
            this.DlugoscSlowa.Text = Convert.ToString(line.Length);
            NoweSlowo = "";
            for (int i = 0; i < line.Length; i++)
            {
                NoweSlowo += '*';
            }
        }

        private void OdpowiedzBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Losowa litera to: " + line[Convert.ToChar(rnd.Next(line.Length))]);
        }
    }
}
