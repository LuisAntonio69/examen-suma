using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbGenero.Items.AddRange(new string[] { "Masculino", "Femenino" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                string nombre = txtnombres.Text.Trim();
                string edadTexto = txtedad.Text.Trim();
                string genero = cbGenero.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(edadTexto) || string.IsNullOrWhiteSpace(genero))
                {
                    MessageBox.Show("Completa todos los campos.");
                    return;
                }
              

                if (!int.TryParse(edadTexto, out  int  edad))
                {
                    MessageBox.Show("Introduce la edad");
                    txtedad.Focus();
                    return;
                }

                string linea = nombre + " - " + edad + " años - " + genero;
                lstDatos.Items.Add(linea);

                try
                {
                    using (StreamWriter sw = new StreamWriter("datos.txt", true))
                    {
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
                txtnombres.Clear();
                txtedad.Clear();
                cbGenero.SelectedIndex = -1;
                txtnombres.Focus();
            }
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
