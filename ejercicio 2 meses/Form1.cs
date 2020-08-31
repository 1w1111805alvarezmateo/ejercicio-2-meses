using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2_meses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();
            this.lstMeses.Items.Add("Enero");
            this.lstMeses.Items.Add("Febrero");
            this.lstMeses.Items.Add("Marzo");
            this.lstMeses.Items.Add("Abril");
            this.lstMeses.Items.Add("Mayo");
            this.lstMeses.Items.Add("Junio");
            this.lstMeses.Items.Add("Julio");
            this.lstMeses.Items.Add("Agosto");
            this.lstMeses.Items.Add("Septiembre");
            this.lstMeses.Items.Add("Octubre");
            this.lstMeses.Items.Add("Noviembre");
            this.lstMeses.Items.Add("Diciembre");

        }
        
	


        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAgregarSelec_Click(object sender, EventArgs e)
        {
            if (!(this.lstMeses.SelectedItem is null))
            {
                this.lstSlectMeses.Items.Add(this.lstMeses.SelectedItem);
                this.lstMeses.Items.Remove(this.lstMeses.SelectedItem);

            }
            else
            {
                MessageBox.Show("seleccione un elemento");
               
            }
                    
            

        }

        private void btnQitarSelec_Click(object sender, EventArgs e)
        {
            if (this.lstSlectMeses.SelectedItem is null)
            {
                MessageBox.Show("seleccione un elemento");
            }
            else
            {

                this.lstMeses.Items.Add(this.lstSlectMeses.SelectedItem);
                this.lstSlectMeses.Items.Remove(this.lstSlectMeses.SelectedItem);
            }
        }

        private void btnAgregarAll_Click(object sender, EventArgs e)
        {
            this.lstSlectMeses.Items.AddRange(this.lstMeses.Items);
            this.lstMeses.Items.Clear();
        }

        private void btnQuitarAll_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.AddRange(this.lstSlectMeses.Items);
            this.lstSlectMeses.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
