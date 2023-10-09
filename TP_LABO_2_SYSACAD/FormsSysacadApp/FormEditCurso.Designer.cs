
namespace FormsSysacadApp
{
    partial class FormEditCurso
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
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.txtDescripCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.lblDescripCurso = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantAlumCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.listHorarios = new System.Windows.Forms.ListBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.lblDiasCursada = new System.Windows.Forms.Label();
            this.cbDiasCursada = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreCurso.Location = new System.Drawing.Point(208, 78);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(242, 27);
            this.txtNombreCurso.TabIndex = 0;
            this.txtNombreCurso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreCurso_KeyDown);
            this.txtNombreCurso.Leave += new System.EventHandler(this.txtNombreCurso_Leave);
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoCurso.Location = new System.Drawing.Point(208, 138);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(66, 27);
            this.txtCodigoCurso.TabIndex = 1;
            this.txtCodigoCurso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCurso_KeyDown);
            this.txtCodigoCurso.Leave += new System.EventHandler(this.txtCodigoCurso_Leave);
            // 
            // txtDescripCurso
            // 
            this.txtDescripCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripCurso.Location = new System.Drawing.Point(208, 195);
            this.txtDescripCurso.Name = "txtDescripCurso";
            this.txtDescripCurso.Size = new System.Drawing.Size(242, 27);
            this.txtDescripCurso.TabIndex = 2;
            this.txtDescripCurso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripCurso_KeyDown);
            this.txtDescripCurso.Leave += new System.EventHandler(this.txtDescripCurso_Leave);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.Location = new System.Drawing.Point(58, 77);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(46, 20);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoCurso.Location = new System.Drawing.Point(58, 141);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(99, 20);
            this.lblCodigoCurso.TabIndex = 4;
            this.lblCodigoCurso.Text = "Codigo Curso";
            // 
            // lblDescripCurso
            // 
            this.lblDescripCurso.AutoSize = true;
            this.lblDescripCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripCurso.Location = new System.Drawing.Point(58, 198);
            this.lblDescripCurso.Name = "lblDescripCurso";
            this.lblDescripCurso.Size = new System.Drawing.Size(87, 20);
            this.lblDescripCurso.TabIndex = 5;
            this.lblDescripCurso.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(299, 412);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 40);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR CAMBIOS";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(104, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantAlumCurso
            // 
            this.txtCantAlumCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantAlumCurso.Location = new System.Drawing.Point(266, 256);
            this.txtCantAlumCurso.Name = "txtCantAlumCurso";
            this.txtCantAlumCurso.Size = new System.Drawing.Size(64, 27);
            this.txtCantAlumCurso.TabIndex = 8;
            this.txtCantAlumCurso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantAlumCurso_KeyDown);
            this.txtCantAlumCurso.Leave += new System.EventHandler(this.txtCantAlumCurso_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad alumnos por Curso";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(208, 104);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(122, 15);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error, ingreso invalido";
            this.lblError.Visible = false;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(239, 309);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(101, 15);
            this.lblHorarios.TabIndex = 27;
            this.lblHorarios.Text = "Horarios Cursada:";
            // 
            // listHorarios
            // 
            this.listHorarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listHorarios.FormattingEnabled = true;
            this.listHorarios.ItemHeight = 20;
            this.listHorarios.Location = new System.Drawing.Point(244, 327);
            this.listHorarios.Name = "listHorarios";
            this.listHorarios.Size = new System.Drawing.Size(86, 64);
            this.listHorarios.TabIndex = 26;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(126, 309);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 15);
            this.lblTurno.TabIndex = 25;
            this.lblTurno.Text = "Turno";
            // 
            // cbTurnos
            // 
            this.cbTurnos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE",
            "NOCHE"});
            this.cbTurnos.Location = new System.Drawing.Point(86, 327);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(121, 28);
            this.cbTurnos.TabIndex = 24;
            this.cbTurnos.SelectedIndexChanged += new System.EventHandler(this.cbTurnos_SelectedIndexChanged);
            // 
            // lblDiasCursada
            // 
            this.lblDiasCursada.AutoSize = true;
            this.lblDiasCursada.Location = new System.Drawing.Point(410, 242);
            this.lblDiasCursada.Name = "lblDiasCursada";
            this.lblDiasCursada.Size = new System.Drawing.Size(91, 15);
            this.lblDiasCursada.TabIndex = 23;
            this.lblDiasCursada.Text = "Dias de Cursada";
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
            this.cbDiasCursada.Location = new System.Drawing.Point(398, 260);
            this.cbDiasCursada.Name = "cbDiasCursada";
            this.cbDiasCursada.Size = new System.Drawing.Size(121, 28);
            this.cbDiasCursada.TabIndex = 22;
            // 
            // FormEditCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(548, 481);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.listHorarios);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cbTurnos);
            this.Controls.Add(this.lblDiasCursada);
            this.Controls.Add(this.cbDiasCursada);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantAlumCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripCurso);
            this.Controls.Add(this.lblCodigoCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtDescripCurso);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Name = "FormEditCurso";
            this.Text = "FormEditCurso";
            this.Load += new System.EventHandler(this.FormEditCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.TextBox txtDescripCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.Label lblDescripCurso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantAlumCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.ListBox listHorarios;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.Label lblDiasCursada;
        private System.Windows.Forms.ComboBox cbDiasCursada;
    }
}