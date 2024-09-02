using _07_Pais_Ciudad.Views;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Lista_Ciudades _lista_Ciudades = new Lista_Ciudades(); // Formulario que contiene los formularios de ciudades y países
           _lista_Ciudades.Show(); // Muestra el formulario
           // this.Hide(); // Oculta el formulario actual
        }
    }
}
