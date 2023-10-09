
namespace FormsSysacadApp
{
    partial class FormAddCurso
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
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.txtNameCurso = new System.Windows.Forms.TextBox();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.txtCodCurso = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblformato = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.lblCantAlumClase = new System.Windows.Forms.Label();
            this.cbDiasCursada = new System.Windows.Forms.ComboBox();
            this.lblDiasCursada = new System.Windows.Forms.Label();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.listHorarios = new System.Windows.Forms.ListBox();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCurso.Location = new System.Drawing.Point(22, 34);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(130, 20);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre del Curso";
            // 
            // txtNameCurso
            // 
            this.txtNameCurso.Location = new System.Drawing.Point(158, 35);
            this.txtNameCurso.Name = "txtNameCurso";
            this.txtNameCurso.Size = new System.Drawing.Size(189, 23);
            this.txtNameCurso.TabIndex = 1;
            this.txtNameCurso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameCurso_KeyDown);
            this.txtNameCurso.Leave += new System.EventHandler(this.txtNameCurso_Leave);
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoCurso.Location = new System.Drawing.Point(22, 107);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(99, 20);
            this.lblCodigoCurso.TabIndex = 2;
            this.lblCodigoCurso.Text = "Codigo Curso";
            // 
            // txtCodCurso
            // 
            this.txtCodCurso.Location = new System.Drawing.Point(139, 107);
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.Size = new System.Drawing.Size(63, 23);
            this.txtCodCurso.TabIndex = 3;
            this.txtCodCurso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCurso_KeyDown);
            this.txtCodCurso.Leave += new System.EventHandler(this.txtCodCurso_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(22, 155);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 20);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(158, 61);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(122, 15);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error, ingreso invalido";
            this.lblError.Visible = false;
            // 
            // lblformato
            // 
            this.lblformato.AutoSize = true;
            this.lblformato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblformato.Location = new System.Drawing.Point(130, 91);
            this.lblformato.Name = "lblformato";
            this.lblformato.Size = new System.Drawing.Size(83, 13);
            this.lblformato.TabIndex = 9;
            this.lblformato.Text = "(formato CXAX)";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(400, 331);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(154, 37);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 37);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(22, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(331, 79);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtCantidadAlumnos
            // 
            this.txtCantidadAlumnos.Location = new System.Drawing.Point(183, 287);
            this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            this.txtCantidadAlumnos.Size = new System.Drawing.Size(45, 23);
            this.txtCantidadAlumnos.TabIndex = 14;
            this.txtCantidadAlumnos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadAlumnos_KeyDown);
            this.txtCantidadAlumnos.Leave += new System.EventHandler(this.txtCantidadAlumnos_Leave);
            // 
            // lblCantAlumClase
            // 
            this.lblCantAlumClase.AutoSize = true;
            this.lblCantAlumClase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantAlumClase.Location = new System.Drawing.Point(25, 287);
            this.lblCantAlumClase.Name = "lblCantAlumClase";
            this.lblCantAlumClase.Size = new System.Drawing.Size(152, 20);
            this.lblCantAlumClase.TabIndex = 15;
            this.lblCantAlumClase.Text = "Cantidad de Alumnos";
            // 
            // cbDiasCursada
            // 
            this.cbDiasCursada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDiasCursada.FormattingEnabled = true;
            this.cbDiasCursada.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES"});
            this.cbDiasCursada.Location = new System.Drawing.Point(421, 61);
            this.cbDiasCursada.Name = "cbDiasCursada";
            this.cbDiasCursada.Size = new System.Drawing.Size(121, 28);
            this.cbDiasCursada.TabIndex = 16;
            this.cbDiasCursada.SelectedIndexChanged += new System.EventHandler(this.cbDiasCursada_SelectedIndexChanged);
            // 
            // lblDiasCursada
            // 
            this.lblDiasCursada.AutoSize = true;
            this.lblDiasCursada.Location = new System.Drawing.Point(433, 43);
            this.lblDiasCursada.Name = "lblDiasCursada";
            this.lblDiasCursada.Size = new System.Drawing.Size(91, 15);
            this.lblDiasCursada.TabIndex = 17;
            this.lblDiasCursada.Text = "Dias de Cursada";
            // 
            // cbTurnos
            // 
            this.cbTurnos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Location = new System.Drawing.Point(421, 122);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(121, 28);
            this.cbTurnos.TabIndex = 18;
            this.cbTurnos.SelectedIndexChanged += new System.EventHandler(this.cbTurnos_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(461, 104);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 15);
            this.lblTurno.TabIndex = 19;
            this.lblTurno.Text = "Turno";
            // 
            // listHorarios
            // 
            this.listHorarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listHorarios.FormattingEnabled = true;
            this.listHorarios.ItemHeight = 20;
            this.listHorarios.Location = new System.Drawing.Point(438, 181);
            this.listHorarios.Name = "listHorarios";
            this.listHorarios.Size = new System.Drawing.Size(86, 64);
            this.listHorarios.TabIndex = 20;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(433, 163);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(101, 15);
            this.lblHorarios.TabIndex = 21;
            this.lblHorarios.Text = "Horarios Cursada:";
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.ItemHeight = 15;
            this.lbCursos.Location = new System.Drawing.Point(634, 61);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(355, 289);
            this.lbCursos.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "CURSOS REGISTRADOS";
            // 
            // FormAddCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 389);
            this.Controls.Add(this.cbDiasCursada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.lbCursos);
            this.Controls.Add(this.lblDiasCursada);
            this.Controls.Add(this.listHorarios);
            this.Controls.Add(this.cbTurnos);
            this.Controls.Add(this.lblCantAlumClase);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtCantidadAlumnos);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblformato);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtCodCurso);
            this.Controls.Add(this.lblCodigoCurso);
            this.Controls.Add(this.txtNameCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW SYSACAD - AGREGAR CURSO";
            this.Load += new System.EventHandler(this.FormAddCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.TextBox txtNameCurso;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.TextBox txtCodCurso;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblformato;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCantidadAlumnos;
        private System.Windows.Forms.Label lblCantAlumClase;
        private System.Windows.Forms.ComboBox cbDiasCursada;
        private System.Windows.Forms.Label lblDiasCursada;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ListBox listHorarios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.ListBox lbCursos;
        private System.Windows.Forms.Label label1;
    }
}