using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExamenDI2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Environment.GetEnvironmentVariable("homedrive");
                openFile.Filter = "Imagenes (*.jpg)|*.jpg|Todos los archivos (*.*)|*.*";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = openFile.FileName;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(eAficion));
        }
    }
}
