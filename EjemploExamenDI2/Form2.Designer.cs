namespace EjemploExamenDI2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbHombre1 = new System.Windows.Forms.RadioButton();
            this.rbMujer1 = new System.Windows.Forms.RadioButton();
            this.groupboxSexo = new System.Windows.Forms.GroupBox();
            this.groupboxSexoOpuesto = new System.Windows.Forms.GroupBox();
            this.rbHombre2 = new System.Windows.Forms.RadioButton();
            this.rbMujer2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtEdad = new EjemploExamenDI2.ValidateTextBox();
            this.txtNombre = new EjemploExamenDI2.ValidateTextBox();
            this.groupboxSexo.SuspendLayout();
            this.groupboxSexoOpuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // rbHombre1
            // 
            this.rbHombre1.AutoSize = true;
            this.rbHombre1.Location = new System.Drawing.Point(35, 33);
            this.rbHombre1.Name = "rbHombre1";
            this.rbHombre1.Size = new System.Drawing.Size(79, 21);
            this.rbHombre1.TabIndex = 0;
            this.rbHombre1.TabStop = true;
            this.rbHombre1.Text = "Hombre";
            this.rbHombre1.UseVisualStyleBackColor = true;
            // 
            // rbMujer1
            // 
            this.rbMujer1.AutoSize = true;
            this.rbMujer1.Location = new System.Drawing.Point(177, 33);
            this.rbMujer1.Name = "rbMujer1";
            this.rbMujer1.Size = new System.Drawing.Size(64, 21);
            this.rbMujer1.TabIndex = 1;
            this.rbMujer1.TabStop = true;
            this.rbMujer1.Text = "Mujer";
            this.rbMujer1.UseVisualStyleBackColor = true;
            // 
            // groupboxSexo
            // 
            this.groupboxSexo.Controls.Add(this.rbHombre1);
            this.groupboxSexo.Controls.Add(this.rbMujer1);
            this.groupboxSexo.Location = new System.Drawing.Point(148, 163);
            this.groupboxSexo.Name = "groupboxSexo";
            this.groupboxSexo.Size = new System.Drawing.Size(299, 76);
            this.groupboxSexo.TabIndex = 7;
            this.groupboxSexo.TabStop = false;
            // 
            // groupboxSexoOpuesto
            // 
            this.groupboxSexoOpuesto.Controls.Add(this.rbHombre2);
            this.groupboxSexoOpuesto.Controls.Add(this.rbMujer2);
            this.groupboxSexoOpuesto.Location = new System.Drawing.Point(148, 245);
            this.groupboxSexoOpuesto.Name = "groupboxSexoOpuesto";
            this.groupboxSexoOpuesto.Size = new System.Drawing.Size(299, 76);
            this.groupboxSexoOpuesto.TabIndex = 9;
            this.groupboxSexoOpuesto.TabStop = false;
            // 
            // rbHombre2
            // 
            this.rbHombre2.AutoSize = true;
            this.rbHombre2.Location = new System.Drawing.Point(35, 33);
            this.rbHombre2.Name = "rbHombre2";
            this.rbHombre2.Size = new System.Drawing.Size(79, 21);
            this.rbHombre2.TabIndex = 0;
            this.rbHombre2.TabStop = true;
            this.rbHombre2.Text = "Hombre";
            this.rbHombre2.UseVisualStyleBackColor = true;
            // 
            // rbMujer2
            // 
            this.rbMujer2.AutoSize = true;
            this.rbMujer2.Location = new System.Drawing.Point(177, 33);
            this.rbMujer2.Name = "rbMujer2";
            this.rbMujer2.Size = new System.Drawing.Size(64, 21);
            this.rbMujer2.TabIndex = 1;
            this.rbMujer2.TabStop = true;
            this.rbMujer2.Text = "Mujer";
            this.rbMujer2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aficion Principal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo Opuesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Foto";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(148, 360);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(142, 22);
            this.txtRuta.TabIndex = 11;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(310, 343);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(112, 51);
            this.btBuscar.TabIndex = 12;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(243, 437);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(204, 96);
            this.btAceptar.TabIndex = 14;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(12, 437);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(206, 96);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(140, 61);
            this.txtEdad.Multilinea = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(320, 42);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.Texto = "";
            this.txtEdad.Tipo = EjemploExamenDI2.ValidateTextBox.eTipo.Numerico;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 9);
            this.txtNombre.Multilinea = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 42);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Texto = "";
            this.txtNombre.Tipo = EjemploExamenDI2.ValidateTextBox.eTipo.Textual;
            // 
            // Form2
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(472, 552);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupboxSexoOpuesto);
            this.Controls.Add(this.groupboxSexo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form2";
            this.Text = "Introducir Datos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupboxSexo.ResumeLayout(false);
            this.groupboxSexo.PerformLayout();
            this.groupboxSexoOpuesto.ResumeLayout(false);
            this.groupboxSexoOpuesto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        public ValidateTextBox txtNombre;
        public ValidateTextBox txtEdad;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.RadioButton rbHombre1;
        public System.Windows.Forms.RadioButton rbMujer1;
        public System.Windows.Forms.GroupBox groupboxSexo;
        public System.Windows.Forms.GroupBox groupboxSexoOpuesto;
        public System.Windows.Forms.RadioButton rbHombre2;
        public System.Windows.Forms.RadioButton rbMujer2;
        public System.Windows.Forms.TextBox txtRuta;
    }
}