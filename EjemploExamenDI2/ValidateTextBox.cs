using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExamenDI2
{
    public partial class ValidateTextBox : UserControl
    {
        bool valido = true;

        [Category("Componente")]
        [Description("Texto")]
        public string Texto
        {
            get => textBox1.Text;
            set
            {
                textBox1.Text = value;
            }
        }

        private bool multilinea;
        [Category("Componente")]
        [Description("Multiline")]
        public bool Multilinea
        {
            get => multilinea;
            set
            {
                multilinea = value;
                textBox1.Multiline = multilinea;
            }
        }

        private eTipo tipo = eTipo.Textual;
        [Category("Componente")]
        [Description("Tipo")]
        public eTipo Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
            }
        }

        public enum eTipo
        {
            Numerico,
            Textual
        }

        public ValidateTextBox()
        {
            InitializeComponent();
        }

        Pen p = new Pen(Color.Red);
        Point inicio = new Point(10, 10);
        protected override void OnPaint(PaintEventArgs e)
        {
            textBox1.Location = inicio;
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;
            comprobar();
            e.Graphics.DrawRectangle(p, 5, 5, this.Width - 10, this.Height - 10);
        }

        private void comprobar()
        {
            valido = true;
            char[] carcteres = textBox1.Text.ToArray();
            foreach (char c in carcteres)
            {
                if (valido)
                {
                    switch (tipo)
                    {
                        case eTipo.Textual:
                            if (!Char.IsLetter(c))
                                valido = false;
                            break;
                        case eTipo.Numerico:
                            if (!Char.IsNumber(c))
                                valido = false;
                            break;
                    }
                }
            }
            if (valido)
                p.Color = Color.Green;
            else
                p.Color = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Refresh();
            CambiaTexto?.Invoke(this, EventArgs.Empty);
        }

        [Category("La propiedad cambio")]
        [Description("Se lanza cuando cambia el texto")]
        public event System.EventHandler CambiaTexto;
    }
}
