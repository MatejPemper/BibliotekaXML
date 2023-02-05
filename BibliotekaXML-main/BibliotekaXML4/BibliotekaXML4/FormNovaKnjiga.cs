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
    public partial class FormNovaKnjiga : Form
    {
        public FormNovaKnjiga()
        {
            InitializeComponent();
        }

        private void buttonNazadUnosaKnjige_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUnesiKnjigu_Click(object sender, EventArgs e)
        {
            {
                List<Knjiga> Knjige = new List<Knjiga>();

                Knjiga kniga = new Knjiga(textBoxImeKnjige.Text, textBoxImeAutora.Text,
                               textBoxPrezimeAutora.Text, Convert.ToInt64(textBoxIDknjige.Text));

                Knjige.Add(kniga);


                DialogResult upit = MessageBox.Show("Zelite li upisati jos osoba?", "Upit", MessageBoxButtons.YesNo);




                if (upit == DialogResult.Yes)
                {
                    Knjige.Add(kniga);


                    textBoxImeKnjige.Clear();
                    textBoxImeAutora.Clear();
                    textBoxPrezimeAutora.Clear();
                    textBoxIDknjige.Clear();

                    Knjige.Add(kniga);

                    


                }
                else
                {

                    foreach (Knjiga knjiga in Knjige)
                    {

                        var Knjiga = new XElement("Korisnik",
                            new XElement("Idknjige", kniga.Idknjige),
                            new XElement("ImeKnjige", kniga.ImeKnjige),
                            new XElement("ImeAutora", kniga.ImeAutora),
                            new XElement("PrezimeAutora", kniga.PrezimeAutora));

                        Knjige.Add(kniga);
                        Knjiga.Save("KnjigeX.xml");

                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

