using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmlistadoPersona : Form
    {
        public frmlistadoPersona()
        {
            InitializeComponent();
        }

        private void BtnNuevoRegistro_Click(object sender, EventArgs e)
        {
            var modal = new frmModal();
            modal.Show();
        }
    }
}
