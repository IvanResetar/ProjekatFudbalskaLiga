using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Kontroleri;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace View.Dialogs.Drzave
{
    public partial class DialogDodajDrzavu : Form
    {
        private KontrolerTimovi kontrolerTimovi;
        public TextBox TxtNazivDrzave { get => txtNazivDrzave; }
        public DialogDodajDrzavu(KontrolerTimovi kontrolerTimovi)
        {
            InitializeComponent();
            this.kontrolerTimovi = kontrolerTimovi;
        }

        private void DialogDodajDrzavu_Load(object sender, EventArgs e)
        {
            kontrolerTimovi.InicijalizujDialogDodajDrzavu(this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kontrolerTimovi.DodajDrzavu();
        }
    }
}
