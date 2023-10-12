
namespace FormsSysacadApp
{
    partial class FormRegStudent
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.lblNumStreet = new System.Windows.Forms.Label();
            this.txtNumStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassProvisional = new System.Windows.Forms.TextBox();
            this.checkChangePass = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInfoEstudiante = new System.Windows.Forms.Label();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(37, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDocumento.Location = new System.Drawing.Point(38, 91);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(87, 20);
            this.lblDocumento.TabIndex = 1;
            this.lblDocumento.Text = "Documento";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(41, 185);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 20);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Calle";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(526, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E -Mail";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(246, 23);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(526, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefono";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(267, 337);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 65);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Alumno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(37, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 23);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(246, 46);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(203, 23);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSurname_KeyDown);
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(37, 114);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(203, 23);
            this.txtDocument.TabIndex = 3;
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(37, 208);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(202, 23);
            this.txtStreet.TabIndex = 4;
            this.txtStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStreet_KeyDown);
            this.txtStreet.Leave += new System.EventHandler(this.txtStreet_Leave);
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(373, 208);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(76, 23);
            this.txtDepto.TabIndex = 6;
            this.txtDepto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepto_KeyDown);
            // 
            // lblNumStreet
            // 
            this.lblNumStreet.AutoSize = true;
            this.lblNumStreet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumStreet.Location = new System.Drawing.Point(258, 185);
            this.lblNumStreet.Name = "lblNumStreet";
            this.lblNumStreet.Size = new System.Drawing.Size(37, 20);
            this.lblNumStreet.TabIndex = 18;
            this.lblNumStreet.Text = "Nro.";
            // 
            // txtNumStreet
            // 
            this.txtNumStreet.Location = new System.Drawing.Point(258, 208);
            this.txtNumStreet.Name = "txtNumStreet";
            this.txtNumStreet.Size = new System.Drawing.Size(70, 23);
            this.txtNumStreet.TabIndex = 5;
            this.txtNumStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumStreet_KeyDown);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(37, 271);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(199, 23);
            this.txtCity.TabIndex = 7;
            this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCity_KeyDown);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contraseña provisional";
            // 
            // txtPassProvisional
            // 
            this.txtPassProvisional.Location = new System.Drawing.Point(258, 114);
            this.txtPassProvisional.Name = "txtPassProvisional";
            this.txtPassProvisional.ReadOnly = true;
            this.txtPassProvisional.Size = new System.Drawing.Size(191, 23);
            this.txtPassProvisional.TabIndex = 18;
            // 
            // checkChangePass
            // 
            this.checkChangePass.AutoSize = true;
            this.checkChangePass.Checked = true;
            this.checkChangePass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkChangePass.Location = new System.Drawing.Point(258, 143);
            this.checkChangePass.Name = "checkChangePass";
            this.checkChangePass.Size = new System.Drawing.Size(191, 19);
            this.checkChangePass.TabIndex = 17;
            this.checkChangePass.Text = "Habilitar cambio de contraseña";
            this.checkChangePass.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(526, 147);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(184, 15);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "Error, formato de ingreso invalido";
            this.lblError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(373, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Piso/Dpto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ciudad";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(526, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(202, 23);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(526, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 23);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(112, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 65);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfoEstudiante);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(497, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 191);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS CARGADOS";
            // 
            // lblInfoEstudiante
            // 
            this.lblInfoEstudiante.AutoSize = true;
            this.lblInfoEstudiante.Location = new System.Drawing.Point(6, 34);
            this.lblInfoEstudiante.Name = "lblInfoEstudiante";
            this.lblInfoEstudiante.Size = new System.Drawing.Size(98, 21);
            this.lblInfoEstudiante.TabIndex = 0;
            this.lblInfoEstudiante.Text = "informacion";
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(329, 253);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(38, 15);
            this.lblPrueba.TabIndex = 26;
            this.lblPrueba.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "PRUEBA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassProvisional);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.checkChangePass);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtNumStreet);
            this.Controls.Add(this.lblNumStreet);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegStudent";
            this.Text = "NEW SYSACAD - REGISTRO NUEVO ALUMNO";
            this.Load += new System.EventHandler(this.FormRegStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label lblNumStreet;
        private System.Windows.Forms.TextBox txtNumStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox checkChangePass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassProvisional;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfoEstudiante;
    }
}