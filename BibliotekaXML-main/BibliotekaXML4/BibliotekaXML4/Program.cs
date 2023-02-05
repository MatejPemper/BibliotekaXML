using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaXML4
{




   internal class Korisnik
    {
        string ime, prezime, mob;
        double idkorisnika;

        public Korisnik(string ime, string prezime, string mob, double idkorisnika)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.mob = mob;
            this.idkorisnika = idkorisnika;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Mob { get => mob; set => mob = value; }
        public double Idkorisnika { get => idkorisnika; set => idkorisnika = value; }

        public override string ToString()
        {
            return "\r\nIme: " + ime + "\r\nPrezime:" + prezime + "\r\nMobilni broj:" + mob;
        }

    }




    internal class Knjiga
    {
        string imeKnjige, imeAutora, prezimeAutora;
        double idknjige;

        public Knjiga(string imeKnjige, string imeAutora, string prezimeAutora, double idknjige)
        {
            this.imeKnjige = imeKnjige;
            this.imeAutora = imeAutora;
            this.prezimeAutora = prezimeAutora;
            this.idknjige = idknjige;
        }

        public string ImeKnjige { get => imeKnjige; set => imeKnjige = value; }
        public string ImeAutora { get => imeAutora; set => imeAutora = value; }
        public string PrezimeAutora { get => prezimeAutora; set => prezimeAutora = value; }
        public double Idknjige { get => idknjige; set => idknjige = value; }

        public override string ToString()
        {
            return "\r\nImeknjige: " + ImeKnjige + "\r\nImeAutora: " + imeAutora + "\r\nPrezime Autora: " + prezimeAutora;
        }
    }




    class Evidencija
    {
        int evd;
        DateTime podizanje = new DateTime();
        DateTime vracanje = new DateTime();

        public Evidencija(int evd, DateTime podizanje, DateTime vracanje)
        {
            this.evd = evd;
            this.podizanje = podizanje;
            this.vracanje = vracanje;
        }

        public int Evd { get => evd; set => evd = value; }
        public DateTime Podizanje { get => podizanje; set => podizanje = value; }
        public DateTime Vracanje { get => vracanje; set => vracanje = value; }
    }






    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
