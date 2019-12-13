using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TobbbformosPizzaAlkalmazasTobbTabla.Repository;

namespace TobbformosMvcPizzaTobbTabla
{
    public partial class FormPizzaFutarKft : Form
    {
        private void tabPageSzamlak_Click(object sender, EventArgs e)
        {
            beallitSzamlakTabPagetIndulaskor();

        }
        private void beallitSzamlakTabPagetIndulaskor()
        {
            listViewRendelesek.Visible = false;
            labelRendelesek.Visible = false;
            dataGridViewTetelek.Visible = false;
            labelTetelek.Visible = false;

        }
        private void tabControlPizzaFutarKFT_Selected(object sender, TabControlEventArgs e)
        {
            beallitSzamlakTabPagetIndulaskor();
        }
    }
}
