
namespace FormsSysacadApp
{
    partial class FormAdminCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminCursos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAddCurso = new System.Windows.Forms.Button();
            this.btnDeleteCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.lblAdminLoged = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCursos = new System.Windows.Forms.DataGridView();
            this.txtDescripCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(288, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 42);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAddCurso
            // 
            this.btnAddCurso.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAddCurso.Location = new System.Drawing.Point(32, 68);
            this.btnAddCurso.Name = "btnAddCurso";
            this.btnAddCurso.Size = new System.Drawing.Size(145, 40);
            this.btnAddCurso.TabIndex = 1;
            this.btnAddCurso.Text = "AGREGAR CURSO";
            this.btnAddCurso.UseVisualStyleBackColor = false;
            this.btnAddCurso.Click += new System.EventHandler(this.btnAddCurso_Click);
            // 
            // btnDeleteCurso
            // 
            this.btnDeleteCurso.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDeleteCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCurso.Location = new System.Drawing.Point(32, 160);
            this.btnDeleteCurso.Name = "btnDeleteCurso";
            this.btnDeleteCurso.Size = new System.Drawing.Size(145, 40);
            this.btnDeleteCurso.TabIndex = 3;
            this.btnDeleteCurso.Text = "ELIMINAR CURSO";
            this.btnDeleteCurso.UseVisualStyleBackColor = false;
            this.btnDeleteCurso.Click += new System.EventHandler(this.btnDeleteCurso_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEditarCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCurso.Location = new System.Drawing.Point(32, 114);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(145, 40);
            this.btnEditarCurso.TabIndex = 5;
            this.btnEditarCurso.Text = "EDITAR CURSO";
            this.btnEditarCurso.UseVisualStyleBackColor = false;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // lblAdminLoged
            // 
            this.lblAdminLoged.AutoSize = true;
            this.lblAdminLoged.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAdminLoged.Location = new System.Drawing.Point(32, 25);
            this.lblAdminLoged.Name = "lblAdminLoged";
            this.lblAdminLoged.Size = new System.Drawing.Size(60, 19);
            this.lblAdminLoged.TabIndex = 6;
            this.lblAdminLoged.Text = "Admin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "CURSOS REGISTRADOS";
            // 
            // dgCursos
            // 
            this.dgCursos.AllowUserToAddRows = false;
            this.dgCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCursos.BackgroundColor = System.Drawing.Color.White;
            this.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursos.Location = new System.Drawing.Point(214, 68);
            this.dgCursos.Name = "dgCursos";
            this.dgCursos.ReadOnly = true;
            this.dgCursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCursos.RowTemplate.Height = 25;
            this.dgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCursos.Size = new System.Drawing.Size(443, 152);
            this.dgCursos.TabIndex = 8;
            this.dgCursos.Click += new System.EventHandler(this.dgCursos_Click);
            // 
            // txtDescripCurso
            // 
            this.txtDescripCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripCurso.Location = new System.Drawing.Point(214, 256);
            this.txtDescripCurso.Name = "txtDescripCurso";
            this.txtDescripCurso.ReadOnly = true;
            this.txtDescripCurso.Size = new System.Drawing.Size(443, 27);
            this.txtDescripCurso.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "DESCRIPCION DEL CURSO";
            // 
            // FormAdminCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FormsSysacadApp.Properties.Resources.FONDO_PRUEBA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripCurso);
            this.Controls.Add(this.dgCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminLoged);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.btnDeleteCurso);
            this.Controls.Add(this.btnAddCurso);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminCursos";
            this.Text = "NEW SYSACAD - PANEL CURSOS";
            this.Activated += new System.EventHandler(this.FormAdminCursos_Activated);
            this.Load += new System.EventHandler(this.FormAdminCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAddCurso;
        private System.Windows.Forms.Button btnDeleteCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Label lblAdminLoged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCursos;
        private System.Windows.Forms.TextBox txtDescripCurso;
        private System.Windows.Forms.Label label2;
    }
}