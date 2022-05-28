using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAD.Model;

namespace Principal
{

    public partial class Pestaña : Form
    {
        public int codigo2;
        public Pestaña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo2.Text.Length == 0)
            {
                MessageBox.Show("No ha ingresado ningun código. Intentelo nuevamente");
                this.Close();
            }

            else
            {
                codigo2 = int.Parse(txtCodigo2.Text);
            }
        }
    }
}
