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


      //  List<Osoba> osobe = new List<Osoba>();
        string dok = "korXML.xml";
        private object osobe;



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
            Korisnik kor = new Korisnik(textBoxImeKorisnika.Text, textBoxPrezimeKorisnika.Text,
                           textBoxBrojKorisnika.Text, Convert.ToInt64(textBoxID.Text));

            DialogResult upit = MessageBox.Show("Zelite li upisati jos osoba?", "Upit", MessageBoxButtons.YesNo);


            if (upit == DialogResult.Yes)
            {
                kor  = new Korisnik(textBoxImeKorisnika.Text, textBoxPrezimeKorisnika.Text,
                           textBoxBrojKorisnika.Text, Convert.ToInt64(textBoxID.Text));

                textBoxImeKorisnika.Clear();
                textBoxPrezimeKorisnika.Clear();
                textBoxBrojKorisnika.Clear() ;
                textBoxID.Clear(); 

            }
            else
            {
                var korXML = new XDocument.Load(dok);

                              
                korXML.Save(kor);



            }



        }
    }
}
