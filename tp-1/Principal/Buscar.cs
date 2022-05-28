using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Buscar : Form
    {
        public int codigoBuscar;
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length == 0)
            {
                MessageBox.Show("No ha ingresado ningun código. Intentelo nuevamente");
                this.Close();
            }

            else
            {
                codigoBuscar = int.Parse(txtBuscar.Text);
            }

        }
    }
}
