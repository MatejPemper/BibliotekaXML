using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace BibliotekaXML4
{

    public partial class FormNoviKorisnik : Form
    {

        public FormNoviKorisnik()
        {
            InitializeComponent();
        }


        private void buttonNazadNoviKorisnik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUnesiNovogKorisnika_Click(object sender, EventArgs e)
        {
            List<Korisnik> Korisnici = new List<Korisnik>();

            Korisnik kor = new Korisnik(textBoxImeKorisnika.Text, textBoxPrezimeKorisnika.Text,
                           textBoxBrojKorisnika.Text, Convert.ToInt64(textBoxID.Text));

            DialogResult upit = MessageBox.Show("Zelite li upisati jos osoba?", "Upit", MessageBoxButtons.YesNo);

            Korisnici.Add(kor);

            

            if (upit == DialogResult.Yes)
            {


                textBoxImeKorisnika.Clear();
                textBoxPrezimeKorisnika.Clear();
                textBoxBrojKorisnika.Clear();
                textBoxID.Clear();

                Korisnici.Add(kor);

            }
            else
            {

                foreach (Korisnik korisnik in Korisnici)
                {

                    var Osoba = new XElement("Korisnik",
                        new XElement("Idkorisnik", kor.Idkorisnika),
                        new XElement("Ime", kor.Ime),
                        new XElement("Prezime", kor.Prezime),
                        new XElement("Mob", kor.Mob));

                    
                    Osoba.Save("KorisnikX.xml");

                }


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    


