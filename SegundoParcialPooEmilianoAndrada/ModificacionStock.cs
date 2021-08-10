using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialPooEmilianoAndrada
{
    public partial class ModificacionStock : Form
    {
        public string codigo;
        public int stock;
        public double precio;
        public ModificacionStock()
        {
            InitializeComponent();
        }

        private void ModificacionStock_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            stock = int.Parse((string)textBox2.Text);
            precio = double.Parse((string)textBox3.Text);
            this.Close();
        }

        public int rStock()
        {
            return stock;
        }
        public double rPrecio()
        {
            return precio;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void AnularTextbox()
        {
            this.textBox3.Enabled = false;
        }
    }
}
