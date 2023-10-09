
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAddCurso = new System.Windows.Forms.Button();
            this.listBoxCursos = new System.Windows.Forms.ListBox();
            this.btnDeleteCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.lblAdminLoged = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(288, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 42);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAddCurso
            // 
            this.btnAddCurso.Location = new System.Drawing.Point(32, 68);
            this.btnAddCurso.Name = "btnAddCurso";
            this.btnAddCurso.Size = new System.Drawing.Size(145, 40);
            this.btnAddCurso.TabIndex = 1;
            this.btnAddCurso.Text = "AGREGAR CURSO";
            this.btnAddCurso.UseVisualStyleBackColor = true;
            this.btnAddCurso.Click += new System.EventHandler(this.btnAddCurso_Click);
            // 
            // listBoxCursos
            // 
            this.listBoxCursos.FormattingEnabled = true;
            this.listBoxCursos.ItemHeight = 15;
            this.listBoxCursos.Location = new System.Drawing.Point(214, 68);
            this.listBoxCursos.Name = "listBoxCursos";
            this.listBoxCursos.Size = new System.Drawing.Size(443, 229);
            this.listBoxCursos.TabIndex = 2;
            // 
            // btnDeleteCurso
            // 
            this.btnDeleteCurso.Location = new System.Drawing.Point(32, 160);
            this.btnDeleteCurso.Name = "btnDeleteCurso";
            this.btnDeleteCurso.Size = new System.Drawing.Size(145, 40);
            this.btnDeleteCurso.TabIndex = 3;
            this.btnDeleteCurso.Text = "ELIMINAR CURSO";
            this.btnDeleteCurso.UseVisualStyleBackColor = true;
            this.btnDeleteCurso.Click += new System.EventHandler(this.btnDeleteCurso_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.Location = new System.Drawing.Point(32, 114);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(145, 40);
            this.btnEditarCurso.TabIndex = 5;
            this.btnEditarCurso.Text = "EDITAR CURSO";
            this.btnEditarCurso.UseVisualStyleBackColor = true;
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
            // FormAdminCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(684, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminLoged);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.btnDeleteCurso);
            this.Controls.Add(this.listBoxCursos);
            this.Controls.Add(this.btnAddCurso);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormAdminCursos";
            this.Text = "NEW SYSACAD - PANEL CURSOS";
            this.Activated += new System.EventHandler(this.FormAdminCursos_Activated);
            this.Load += new System.EventHandler(this.FormAdminCursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAddCurso;
        private System.Windows.Forms.ListBox listBoxCursos;
        private System.Windows.Forms.Button btnDeleteCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Label lblAdminLoged;
        private System.Windows.Forms.Label label1;
    }
}