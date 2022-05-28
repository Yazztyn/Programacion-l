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
    public partial class Form1 : Form
    {

        public Cola Cola { get; set; } = new Cola();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length>0)
            {
                Factura factura = new Factura();
                factura.codigo = int.Parse(txtCodigo.Text);

                Cola.Enqueue(factura);
                lstFacturas.Items.Add(factura.codigo);
            }
            else
            {
                MessageBox.Show("No ha ingresado ningun código. Intentelo nuevamente.");
            }
            
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (lstFacturas.Items.Count > 0)
            {
                Factura factura = Cola.Dequeue();
                MessageBox.Show($"Desencolando el codigo: {factura.codigo}");

                lstFacturas.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Todavía no has ingresado ningun código.");
            }
            
        }

        private void btnTope_Click(object sender, EventArgs e)
        {
            if (lstFacturas.Items.Count > 0)
            {
                MessageBox.Show($"El primer codigo es: {Cola.PeekAlFinal().ToString()}");
            }
            else
            {
                MessageBox.Show("Todavía no has ingresado ningun código.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPestaña_Click(object sender, EventArgs e)
        {
            Pestaña Pestaña = new Pestaña();
            if(Pestaña.ShowDialog() == DialogResult.OK)
            {
                if(Pestaña.codigo2 != 0)                //Valido que no se deje el txtcodigo2 en blanco
                {
                    Factura factura = new Factura();
                    factura.codigo = Pestaña.codigo2;
                    Cola.Enqueue(factura);
                    lstFacturas.Items.Add(Pestaña.codigo2);
                    MessageBox.Show($"Se agregó a la lista el código {factura.codigo}");
                }
            }
            else
            {
                MessageBox.Show("El proceso fue cancelado");
            }
        }

        private void btnFormBuscar_Click(object sender, EventArgs e)
        {
            Buscar Buscar = new Buscar();
            if (Buscar.ShowDialog() == DialogResult.OK)
            {
                if (Buscar.codigoBuscar != 0)                                                       //Valido que no se deje el txtBuscar en blanco
                {
                    Factura factura = new Factura();
                    int codigoEncontrado = Cola.BuscarFactura(Buscar.codigoBuscar).codigo;          // Lo que me devuelve variable y yo le
                                                                                                    // agrego .codigo para que me de el número encontrado.
                    int index = lstFacturas.FindString(codigoEncontrado.ToString()) + 1;            // Busco el índice del código encontrado y le sumo uno
                                                                                                    // para que quede mejor esteticamente debido a que
                                                                                                    // empieza desde el 0.
                    MessageBox.Show($"El código {codigoEncontrado} se encuentra en la posición {index.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("El proceso fue cancelado");
            }
        }
    }
}
