
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
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDecsripcion = new System.Windows.Forms.Label();
            this.lblListadoCursos = new System.Windows.Forms.Label();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.dgCursoInscripto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursoInscripto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTurnos
            // 
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Items.AddRange(new object[] {
            "(TODOS)",
            "MAÑANA",
            "TARDE",
            "NOCHE"});
            this.cbTurnos.Location = new System.Drawing.Point(494, 108);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(121, 23);
            this.cbTurnos.TabIndex = 1;
            this.cbTurnos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Location = new System.Drawing.Point(494, 198);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(131, 64);
            this.btnInscribirse.TabIndex = 2;
            this.btnInscribirse.Text = "INSCRIBIRSE";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(657, 456);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 23);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDecsripcion
            // 
            this.lblDecsripcion.AutoSize = true;
            this.lblDecsripcion.Location = new System.Drawing.Point(657, 428);
            this.lblDecsripcion.Name = "lblDecsripcion";
            this.lblDecsripcion.Size = new System.Drawing.Size(140, 15);
            this.lblDecsripcion.TabIndex = 5;
            this.lblDecsripcion.Text = "Descripcion de la Materia";
            // 
            // lblListadoCursos
            // 
            this.lblListadoCursos.AutoSize = true;
            this.lblListadoCursos.BackColor = System.Drawing.Color.Transparent;
            this.lblListadoCursos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoCursos.Location = new System.Drawing.Point(657, 52);
            this.lblListadoCursos.Name = "lblListadoCursos";
            this.lblListadoCursos.Size = new System.Drawing.Size(157, 20);
            this.lblListadoCursos.TabIndex = 6;
            this.lblListadoCursos.Text = "CURSOS DISPONIBLES";
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurnos.Location = new System.Drawing.Point(527, 75);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(53, 20);
            this.lblTurnos.TabIndex = 7;
            this.lblTurnos.Text = "Turnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "CURSOS:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(185, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 64);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "INSCRIBIR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgCursos
            // 
            this.dgCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCursos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Location = new System.Drawing.Point(657, 85);
            this.dgCursos.MultiSelect = false;
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.ReadOnly = true;
            this.dgCursos.RowHeadersVisible = false;
            this.dgCursos.RowTemplate.Height = 25;
            this.dgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCursos.Size = new System.Drawing.Size(416, 324);
            this.dgCursos.TabIndex = 11;
            // 
            // dgCursoInscripto
            // 
            this.dgCursoInscripto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCursoInscripto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCursoInscripto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursoInscripto.Location = new System.Drawing.Point(32, 85);
            this.dgCursoInscripto.MultiSelect = false;
            this.dgCursoInscripto.Name = "dgCursoInscripto";
            this.dgCursoInscripto.ReadOnly = true;
            this.dgCursoInscripto.RowHeadersVisible = false;
            this.dgCursoInscripto.RowTemplate.Height = 25;
            this.dgCursoInscripto.Size = new System.Drawing.Size(416, 324);
            this.dgCursoInscripto.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "PRUEBA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInscripCursosAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::FormsSysacadApp.Properties.Resources.FONDO_PRUEBA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgCursoInscripto);
            this.Controls.Add(this.dgCursos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.lblListadoCursos);
            this.Controls.Add(this.lblDecsripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.cbTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInscripCursosAlum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW SYSACAD - INSCRIPCION A CURSOS";
            this.Load += new System.EventHandler(this.FormInscripCursosAlum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursoInscripto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDecsripcion;
        private System.Windows.Forms.Label lblListadoCursos;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgCursos;
        private System.Windows.Forms.DataGridView dgCursoInscripto;
        private System.Windows.Forms.Button button1;
    }
}