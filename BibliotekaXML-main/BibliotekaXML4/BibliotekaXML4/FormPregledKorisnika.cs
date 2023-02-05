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
    public partial class FormPregledKorisnika : Form
    {
        public FormPregledKorisnika()
        {
            InitializeComponent();
        }

        private void buttonNazadUnosaKnjige_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
