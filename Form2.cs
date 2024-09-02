using _07_Pais_Ciudad.Controllers;
using _07_Pais_Ciudad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Pais_Ciudad
{
    public partial class Form2 : Form
    {
        private string id;
       
        public Form2(string id)
        {
            InitializeComponent();
            this.id = id;
            
        }
       


        private void Form2_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(this.id);
            PaisesControllers _paises = new PaisesControllers();
            comboBox1.DataSource = _paises.todos();
            comboBox1.DisplayMember = "Detalle";
            comboBox1.ValueMember = "IdPais";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
