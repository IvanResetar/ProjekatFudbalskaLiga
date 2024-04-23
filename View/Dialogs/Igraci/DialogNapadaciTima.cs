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

namespace View.Dialogs.Igraci
{
    public partial class DialogNapadaciTima : Form
    {
        private KontrolerTimovi kontrolerTimovi;
        private Tim tim;
        public DataGridView DataGridNapadaci { get => dgNapadaciTima; }

        public DialogNapadaciTima(KontrolerTimovi kontrolerTimovi, Tim tim)
        {
            InitializeComponent();
            this.tim = tim;
            this.kontrolerTimovi = kontrolerTimovi;
        }

        private void DialogNapadaciTima_Load(object sender, EventArgs e)
        {
            kontrolerTimovi.InicijalizujDialogNapadaciTima(this, tim);
        }
    }
}
