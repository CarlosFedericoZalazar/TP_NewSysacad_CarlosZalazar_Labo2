
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAsignatura = new System.Windows.Forms.ComboBox();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
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
            this.txtCodCurso.Location = new System.Drawing.Point(290, 111);
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.ReadOnly = true;
            this.txtCodCurso.Size = new System.Drawing.Size(63, 23);
            this.txtCodCurso.TabIndex = 3;
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
            this.lblformato.Location = new System.Drawing.Point(281, 95);
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
            this.btnAceptar.TabIndex = 9;
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
            this.txtDescription.TabIndex = 4;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtCantidadAlumnos
            // 
            this.txtCantidadAlumnos.Location = new System.Drawing.Point(183, 287);
            this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            this.txtCantidadAlumnos.Size = new System.Drawing.Size(45, 23);
            this.txtCantidadAlumnos.TabIndex = 5;
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
            this.cbDiasCursada.TabIndex = 6;
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
            this.cbTurnos.TabIndex = 7;
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
            this.listHorarios.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "CURSOS REGISTRADOS";
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCurso.Location = new System.Drawing.Point(158, 108);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(32, 23);
            this.cbCurso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "A";
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbAsignatura.Location = new System.Drawing.Point(220, 108);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(32, 23);
            this.cbAsignatura.TabIndex = 3;
            this.cbAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbAsignatura_SelectedIndexChanged);
            // 
            // dgCursos
            // 
            this.dgCursos.AllowUserToAddRows = false;
            this.dgCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Turno});
            this.dgCursos.Location = new System.Drawing.Point(584, 61);
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.RowTemplate.Height = 25;
            this.dgCursos.Size = new System.Drawing.Size(407, 246);
            this.dgCursos.TabIndex = 29;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            // 
            // FormAddCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 389);
            this.Controls.Add(this.dgCursos);
            this.Controls.Add(this.cbAsignatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.cbDiasCursada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHorarios);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAsignatura;
        private System.Windows.Forms.DataGridView dgCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
    }
}