using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaXML4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPosudba_Click(object sender, EventArgs e)
        {
            FormPosudba form = new FormPosudba();
            form.ShowDialog();
        }

        private void buttonNoviKorisnik_Click(object sender, EventArgs e)
        {
            FormNoviKorisnik form = new FormNoviKorisnik();
            form.ShowDialog();
        }

        private void buttonNovaKnjiga_Click(object sender, EventArgs e)
        {
            FormNovaKnjiga form = new FormNovaKnjiga();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
