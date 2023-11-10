
namespace FormsSysacadApp
{
    partial class FormAlumno
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
            this.lblAlumnoLogued = new System.Windows.Forms.Label();
            this.btnInscipCursos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlumnoLogued
            // 
            this.lblAlumnoLogued.AutoSize = true;
            this.lblAlumnoLogued.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAlumnoLogued.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAlumnoLogued.ForeColor = System.Drawing.Color.Black;
            this.lblAlumnoLogued.Location = new System.Drawing.Point(12, 9);
            this.lblAlumnoLogued.Name = "lblAlumnoLogued";
            this.lblAlumnoLogued.Size = new System.Drawing.Size(80, 23);
            this.lblAlumnoLogued.TabIndex = 0;
            this.lblAlumnoLogued.Text = "Alumno: ";
            // 
            // btnInscipCursos
            // 
            this.btnInscipCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInscipCursos.Location = new System.Drawing.Point(388, 63);
            this.btnInscipCursos.Name = "btnInscipCursos";
            this.btnInscipCursos.Size = new System.Drawing.Size(199, 77);
            this.btnInscipCursos.TabIndex = 2;
            this.btnInscipCursos.Text = "INSCRIPCION DE CURSOS";
            this.btnInscipCursos.UseVisualStyleBackColor = true;
            this.btnInscipCursos.Click += new System.EventHandler(this.btnInscipCursos_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(37, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsSysacadApp.Properties.Resources.imagen_UTN;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(388, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "CONSULTAR HORARIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPago
            // 
            this.btnPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPago.Location = new System.Drawing.Point(388, 298);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(199, 77);
            this.btnPago.TabIndex = 6;
            this.btnPago.Text = "REALIZAR PAGOS";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::FormsSysacadApp.Properties.Resources.FONDO_PRUEBA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 432);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInscipCursos);
            this.Controls.Add(this.lblAlumnoLogued);
            this.Name = "FormAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Alumno - NEW SYSACAD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAlumno_FormClosed);
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumnoLogued;
        private System.Windows.Forms.Button btnInscipCursos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPago;
    }
}