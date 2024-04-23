using Domen;
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
using View.UserControls;

namespace View.Dialogs.Timovi
{
    public partial class DialogUtakmiceTima : Form
    {
        private KontrolerTimovi kontrolerTimovi;
        private Tim tim;

        public Label NaslovUtakmiceTima { get => lblUtakmiceTima; }
        public DataGridView DataGridUtakmice { get => dgUtakmice; }
        public DialogUtakmiceTima(KontrolerTimovi kontrolerTimovi, Tim tim)
        {
            InitializeComponent();
            this.kontrolerTimovi = kontrolerTimovi;
            this.tim = tim;
        }

        private void DialogUtakmiceTima_Load(object sender, EventArgs e)
        {
            kontrolerTimovi.InicijalizujDialogUtakmiceTima(this, tim);
        }
    }
}
