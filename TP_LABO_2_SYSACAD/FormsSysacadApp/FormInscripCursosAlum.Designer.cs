
namespace FormsSysacadApp
{
    partial class FormInscripCursosAlum
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
            this.listMaterias = new System.Windows.Forms.ListBox();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDecsripcion = new System.Windows.Forms.Label();
            this.lblListadoCursos = new System.Windows.Forms.Label();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.listCursosAlumno = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMaterias
            // 
            this.listMaterias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMaterias.FormattingEnabled = true;
            this.listMaterias.ItemHeight = 20;
            this.listMaterias.Location = new System.Drawing.Point(520, 85);
            this.listMaterias.Name = "listMaterias";
            this.listMaterias.Size = new System.Drawing.Size(247, 324);
            this.listMaterias.TabIndex = 0;
            this.listMaterias.SelectedIndexChanged += new System.EventHandler(this.listMaterias_SelectedIndexChanged_1);
            // 
            // cbTurnos
            // 
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Items.AddRange(new object[] {
            "(TODOS)",
            "MAÑANA",
            "TARDE",
            "NOCHE"});
            this.cbTurnos.Location = new System.Drawing.Point(369, 85);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(121, 23);
            this.cbTurnos.TabIndex = 1;
            this.cbTurnos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Location = new System.Drawing.Point(350, 183);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(131, 64);
            this.btnInscribirse.TabIndex = 2;
            this.btnInscribirse.Text = "INSCRIBIRSE";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(520, 443);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 23);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDecsripcion
            // 
            this.lblDecsripcion.AutoSize = true;
            this.lblDecsripcion.Location = new System.Drawing.Point(520, 415);
            this.lblDecsripcion.Name = "lblDecsripcion";
            this.lblDecsripcion.Size = new System.Drawing.Size(140, 15);
            this.lblDecsripcion.TabIndex = 5;
            this.lblDecsripcion.Text = "Descripcion de la Materia";
            // 
            // lblListadoCursos
            // 
            this.lblListadoCursos.AutoSize = true;
            this.lblListadoCursos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoCursos.Location = new System.Drawing.Point(560, 52);
            this.lblListadoCursos.Name = "lblListadoCursos";
            this.lblListadoCursos.Size = new System.Drawing.Size(157, 20);
            this.lblListadoCursos.TabIndex = 6;
            this.lblListadoCursos.Text = "CURSOS DISPONIBLES";
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurnos.Location = new System.Drawing.Point(402, 52);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(53, 20);
            this.lblTurnos.TabIndex = 7;
            this.lblTurnos.Text = "Turnos";
            // 
            // listCursosAlumno
            // 
            this.listCursosAlumno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listCursosAlumno.FormattingEnabled = true;
            this.listCursosAlumno.ItemHeight = 20;
            this.listCursosAlumno.Location = new System.Drawing.Point(54, 85);
            this.listCursosAlumno.Name = "listCursosAlumno";
            this.listCursosAlumno.Size = new System.Drawing.Size(247, 324);
            this.listCursosAlumno.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "CURSOS:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(114, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 64);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "INSCRIBIR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormInscripCursosAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(853, 516);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCursosAlumno);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.lblListadoCursos);
            this.Controls.Add(this.lblDecsripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.cbTurnos);
            this.Controls.Add(this.listMaterias);
            this.Name = "FormInscripCursosAlum";
            this.Text = "FormInscripCursosAlum";
            this.Load += new System.EventHandler(this.FormInscripCursosAlum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMaterias;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDecsripcion;
        private System.Windows.Forms.Label lblListadoCursos;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.ListBox listCursosAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
    }
}