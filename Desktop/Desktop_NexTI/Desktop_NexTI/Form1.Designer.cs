namespace Desktop_NexTI
{
    partial class btnimg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblnombre = new Label();
            lblapellido = new Label();
            lblcedula = new Label();
            lbltelefono = new Label();
            lblcorreo = new Label();
            lblimg = new Label();
            lblcursos = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtcedula = new TextBox();
            txttelefono = new TextBox();
            txtcorreo = new TextBox();
            txtcurso = new TextBox();
            btnGuardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            ptbPerfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbPerfil).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(98, 107);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(98, 173);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(51, 15);
            lblapellido.TabIndex = 1;
            lblapellido.Text = "Apellido";
            // 
            // lblcedula
            // 
            lblcedula.AutoSize = true;
            lblcedula.Location = new Point(98, 229);
            lblcedula.Name = "lblcedula";
            lblcedula.Size = new Size(44, 15);
            lblcedula.TabIndex = 2;
            lblcedula.Text = "Cedula";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(436, 102);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(52, 15);
            lbltelefono.TabIndex = 3;
            lbltelefono.Text = "Telefono";
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Location = new Point(436, 168);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(43, 15);
            lblcorreo.TabIndex = 4;
            lblcorreo.Text = "Correo";
            // 
            // lblimg
            // 
            lblimg.AutoSize = true;
            lblimg.Location = new Point(98, 338);
            lblimg.Name = "lblimg";
            lblimg.Size = new Size(77, 15);
            lblimg.TabIndex = 5;
            lblimg.Text = "Foto de Perfil";
            // 
            // lblcursos
            // 
            lblcursos.AutoSize = true;
            lblcursos.Location = new Point(436, 224);
            lblcursos.Name = "lblcursos";
            lblcursos.Size = new Size(43, 15);
            lblcursos.TabIndex = 6;
            lblcursos.Text = "Cursos";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(192, 99);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(141, 23);
            txtnombre.TabIndex = 7;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(192, 165);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(141, 23);
            txtapellido.TabIndex = 8;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(192, 221);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(141, 23);
            txtcedula.TabIndex = 9;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(534, 99);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(163, 23);
            txttelefono.TabIndex = 10;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(534, 165);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(163, 23);
            txtcorreo.TabIndex = 11;
            // 
            // txtcurso
            // 
            txtcurso.Location = new Point(534, 221);
            txtcurso.Name = "txtcurso";
            txtcurso.Size = new Size(163, 23);
            txtcurso.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(483, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(194, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(212, 360);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 14;
            button1.Text = "Cargar Archivo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ptbPerfil
            // 
            ptbPerfil.Location = new Point(224, 289);
            ptbPerfil.Name = "ptbPerfil";
            ptbPerfil.Size = new Size(100, 50);
            ptbPerfil.TabIndex = 15;
            ptbPerfil.TabStop = false;
            // 
            // btnimg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ptbPerfil);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtcurso);
            Controls.Add(txtcorreo);
            Controls.Add(txttelefono);
            Controls.Add(txtcedula);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(lblcursos);
            Controls.Add(lblimg);
            Controls.Add(lblcorreo);
            Controls.Add(lbltelefono);
            Controls.Add(lblcedula);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Name = "btnimg";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptbPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lblapellido;
        private Label lblcedula;
        private Label lbltelefono;
        private Label lblcorreo;
        private Label lblimg;
        private Label lblcursos;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcedula;
        private TextBox txttelefono;
        private TextBox txtcorreo;
        private TextBox txtcurso;
        private Button btnGuardar;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private PictureBox ptbPerfil;
    }
}