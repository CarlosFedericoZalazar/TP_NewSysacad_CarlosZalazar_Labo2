
namespace FormsSysacadApp
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.lblAdminLogued = new System.Windows.Forms.Label();
            this.btnRegEstudiante = new System.Windows.Forms.Button();
            this.btnGestionCurso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminLogued
            // 
            this.lblAdminLogued.AutoSize = true;
            this.lblAdminLogued.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminLogued.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAdminLogued.Location = new System.Drawing.Point(12, 18);
            this.lblAdminLogued.Name = "lblAdminLogued";
            this.lblAdminLogued.Size = new System.Drawing.Size(64, 19);
            this.lblAdminLogued.TabIndex = 0;
            this.lblAdminLogued.Text = "Admin: ";
            // 
            // btnRegEstudiante
            // 
            this.btnRegEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegEstudiante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegEstudiante.Location = new System.Drawing.Point(482, 127);
            this.btnRegEstudiante.Name = "btnRegEstudiante";
            this.btnRegEstudiante.Size = new System.Drawing.Size(129, 57);
            this.btnRegEstudiante.TabIndex = 1;
            this.btnRegEstudiante.Text = "Registrar Estudiante";
            this.btnRegEstudiante.UseVisualStyleBackColor = false;
            this.btnRegEstudiante.Click += new System.EventHandler(this.btnRegEstudiante_Click);
            // 
            // btnGestionCurso
            // 
            this.btnGestionCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGestionCurso.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGestionCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGestionCurso.Location = new System.Drawing.Point(482, 53);
            this.btnGestionCurso.Name = "btnGestionCurso";
            this.btnGestionCurso.Size = new System.Drawing.Size(129, 57);
            this.btnGestionCurso.TabIndex = 2;
            this.btnGestionCurso.Text = "Gestionar Cursos";
            this.btnGestionCurso.UseVisualStyleBackColor = false;
            this.btnGestionCurso.Click += new System.EventHandler(this.btnGestionCurso_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(12, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 51);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 347);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::FormsSysacadApp.Properties.Resources.FONDO_PRUEBA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionCurso);
            this.Controls.Add(this.btnRegEstudiante);
            this.Controls.Add(this.lblAdminLogued);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Administrador - NEW SYSACAD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminLogued;
        private System.Windows.Forms.Button btnRegEstudiante;
        private System.Windows.Forms.Button btnGestionCurso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}