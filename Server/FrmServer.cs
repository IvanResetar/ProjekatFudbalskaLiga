using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ovo su direktive za uključivanje potrebnih namespace-ova.
//NPR, System.Windows.Forms sadrži klase koje su potrebne za izradu Windows Forms aplikacija.

namespace Server
{
    public partial class FrmServer : Form
    {
        private ServerKlasa server;

        public FrmServer()
        {
            InitializeComponent();
        }

        //Definise se namespace Server,
        //a unutar njega klasa FrmServer koja nasljeđuje Form (Windows Form).
        //Takođe, deklarise se privatno polje server tipa ServerKlasa.
        //Konstruktor FrmServer je deo klase i poziva
        //InitializeComponent() metodu koja inicijalizira komponente forme.



        private void FrmServer_Load(object sender, EventArgs e)
        {
            
            btnZaustavi.Enabled = false;
            pictureBox1.Visible = false;
            label2.Visible = false;
            
        }

        //Ova metoda se poziva kada se forma učita.
        //Ona postavlja početno stanje kontrole na formi:
        //dugme btnZaustavi je onemogućeno (false), a pictureBox1 i label2 su skriveni (Visible = false).

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                server = new ServerKlasa();
                server.Pokreni();
                Thread nit = new Thread(server.OsluskujMrezu);
                nit.IsBackground = true;
                nit.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                pictureBox1.Visible = true;
                label2.Visible = true;
            }
            catch (SocketException ex)
            {

                Console.WriteLine(ex);
                MessageBox.Show("Greska prilikom rada servera");
            }

        }

        //Ova metoda se poziva kada korisnik klikne na dugme btnPokreni.
        //Pokušava stvoriti novu instancu ServerKlasa,
        //pokreće server, stvara novu nit (thread) za osluškivanje mreže i pokreće tu nit.
        //Takođe menja stanja kontrola na formi: btnPokreni postaje onemogućeno,
        //a btnZaustavi, pictureBox1 i label2 postaju vidljivi.
        //Ako dođe do greške prilikom pokretanja servera, hvata se SocketException i prikazuje se poruka o grešci.

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server.ZaustaviServer();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            pictureBox1.Visible = false;
            label2.Visible = false;

        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            
        }

        //Ova metoda se poziva kada se forma zatvori. Pokušava zatvoriti sve niti i izlazi iz aplikacije
    }
}
