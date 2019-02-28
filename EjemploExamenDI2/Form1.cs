using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExamenDI2
{
    public partial class Form1 : Form
    {
        string titulo = " Frikilove Inc";
        int contTitulo;
        private List<sFriki> frikis = new List<sFriki>();
        public delegate void delegaTiempo();
        private static readonly object l = new object();

        public Form1()
        {
            InitializeComponent();
            contTitulo = titulo.Length - 1;
            Thread tiempo = new Thread(() => tiempoTitulo());
            tiempo.IsBackground = true;
            tiempo.Start();
        }

        private void cambiaTitulo()
        {
            contTitulo++;
            if (contTitulo >= titulo.Length)
                contTitulo = 0;
            this.Text = titulo.Substring(titulo.Length - contTitulo - 1);
        }

        private void tiempoTitulo()
        {
            delegaTiempo delegado = cambiaTitulo;
            while (true)
            {
                try
                {
                    this.Invoke(delegado);
                }
                catch (ObjectDisposedException) { }
                Thread.Sleep(200);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sFriki friki1, friki2, friki3, friki4, friki5, friki6, friki7, friki8;

            friki1.nombre = "friki1";
            friki1.edad = 1;
            friki1.aficion = eAficion.Fantasia;
            friki1.sexo = eSexo.Hombre;
            friki1.sexoOpuesto = eSexo.Hombre;
            friki1.foto = "D:\\Imagenes\\1_1_Alex_Criville.jpg";

            friki2.nombre = "friki2";
            friki2.edad = 5;
            friki2.aficion = eAficion.Tecnologia;
            friki2.sexo = eSexo.Hombre;
            friki2.sexoOpuesto = eSexo.Mujer;
            friki2.foto = "D:\\Imagenes\\1_2_Alex_Criville.jpg";

            friki3.nombre = "friki3";
            friki3.edad = 3;
            friki3.aficion = eAficion.SciFi;
            friki3.sexo = eSexo.Mujer;
            friki3.sexoOpuesto = eSexo.Mujer;
            friki3.foto = "D:\\Imagenes\\1_3_Alex_Criville.jpg";

            friki4.nombre = "friki4";
            friki4.edad = 3;
            friki4.aficion = eAficion.SciFi;
            friki4.sexo = eSexo.Hombre;
            friki4.sexoOpuesto = eSexo.Mujer;
            friki4.foto = "D:\\Imagenes\\1_4_Alex_Criville.jpg";

            friki5.nombre = "friki5";
            friki5.edad = 3;
            friki5.aficion = eAficion.SciFi;
            friki5.sexo = eSexo.Hombre;
            friki5.sexoOpuesto = eSexo.Hombre;
            friki5.foto = "D:\\Imagenes\\1_5_Alex_Criville.jpg";

            friki6.nombre = "friki6";
            friki6.edad = 3;
            friki6.aficion = eAficion.SciFi;
            friki6.sexo = eSexo.Mujer;
            friki6.sexoOpuesto = eSexo.Hombre;
            friki6.foto = "D:\\Imagenes\\2_1_Alexander_Popov.jpg";

            friki7.nombre = "friki7";
            friki7.edad = 3;
            friki7.aficion = eAficion.SciFi;
            friki7.sexo = eSexo.Mujer;
            friki7.sexoOpuesto = eSexo.Mujer;
            friki7.foto = "D:\\Imagenes\\2_2_Alexander_Popov.jpg";

            friki8.nombre = "friki8";
            friki8.edad = 3;
            friki8.aficion = eAficion.Tecnologia;
            friki8.sexo = eSexo.Hombre;
            friki8.sexoOpuesto = eSexo.Mujer;
            friki8.foto = "D:\\Imagenes\\2_3_Alexander_Popov.jpg";

            frikis.Add(friki1);
            frikis.Add(friki2);
            frikis.Add(friki3);
            frikis.Add(friki4);
            frikis.Add(friki5);
            frikis.Add(friki6);
            frikis.Add(friki7);
            frikis.Add(friki8);

            foreach (sFriki friki in frikis)
            {
                listBox1.Items.Add(friki.nombre);
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult res = form2.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                sFriki friki;
                friki.nombre = form2.txtNombre.Texto;
                try
                {
                    friki.edad = Convert.ToInt32(form2.txtEdad.Texto);
                }
                catch
                {
                    friki.edad = 0;
                }
                friki.aficion = (eAficion)form2.comboBox1.SelectedItem;
                if (form2.rbHombre1.Checked)
                    friki.sexo = eSexo.Hombre;
                else
                    friki.sexo = eSexo.Mujer;
                if (form2.rbHombre2.Checked)
                    friki.sexoOpuesto = eSexo.Hombre;
                else
                    friki.sexoOpuesto = eSexo.Mujer;
                friki.foto = form2.txtRuta.Text;

                //comprobar valido
                Console.WriteLine(friki.nombre);
                Console.WriteLine(friki.edad);
                Console.WriteLine(friki.aficion);
                Console.WriteLine(friki.sexo);
                Console.WriteLine(friki.sexoOpuesto);
                Console.WriteLine(friki.foto);

                frikis.Add(friki);
                listBox1.Items.Add(friki.nombre);
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i > -1; i--)
            {
                frikis.RemoveAt(listBox1.SelectedIndices[i]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ero Sobrino Dorado", "Frikilove Inc");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (listBox1.SelectedIndex != -1)
            {
                sFriki friki = frikis[listBox1.SelectedIndex];
                try
                {
                    Bitmap imagen = new Bitmap(friki.foto);
                    pictureBox1.Image = imagen;
                    int tamañoAncho = imagen.Height * 200 / imagen.Width;
                    pictureBox1.ClientSize = new Size(200,tamañoAncho);
                }
                catch (FileNotFoundException) { pictureBox1.Image = null; }
                catch (ArgumentException) { pictureBox1.Image = null; }
                toolTip1.SetToolTip(pictureBox1, friki.nombre + Environment.NewLine + friki.edad + Environment.NewLine + friki.aficion);

                int y = 20;
                foreach (sFriki frikiPareja in frikis)
                {
                    if (!frikiPareja.Equals(friki))
                    {
                        if (frikiPareja.aficion == friki.aficion
                            && friki.sexo == frikiPareja.sexoOpuesto
                            && friki.sexoOpuesto == frikiPareja.sexo)
                        {
                            Label lblNombre = new Label();
                            Label lblNombreFriki = new Label();

                            lblNombre.Location = new Point(20, y);
                            lblNombre.Size = new Size(50, 20);
                            lblNombre.Text = "Nombre";

                            lblNombreFriki.Location = new Point(70, y);
                            lblNombreFriki.Size = new Size(80, 20);
                            lblNombreFriki.Text = frikiPareja.nombre;

                            y += 20;

                            panel1.Controls.Add(lblNombre);
                            panel1.Controls.Add(lblNombreFriki);
                        }
                    }
                }

            }
            else
            {
                toolTip1.SetToolTip(pictureBox1, "");
                pictureBox1.Image = null;
            }
        }
    }

    public enum eAficion
    {
        Manga,
        SciFi,
        RPG,
        Fantasia,
        Terror,
        Tecnologia
    }

    enum eSexo
    {
        Hombre,
        Mujer
    }

    struct sFriki
    {
        public string nombre;
        public int edad;
        public eAficion aficion;
        public eSexo sexo;
        public eSexo sexoOpuesto;
        public string foto;
    }
}
