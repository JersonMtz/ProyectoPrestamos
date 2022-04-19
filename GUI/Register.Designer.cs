namespace ProyectoPrestamos
{
    partial class Register
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRiesgo = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.MaskedTextBox();
            this.password1 = new System.Windows.Forms.MaskedTextBox();
            this.typePerson = new System.Windows.Forms.ComboBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSegApellido = new System.Windows.Forms.TextBox();
            this.txtPriApellido = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRiesgo);
            this.groupBox1.Controls.Add(this.password2);
            this.groupBox1.Controls.Add(this.password1);
            this.groupBox1.Controls.Add(this.typePerson);
            this.groupBox1.Controls.Add(this.lblChange);
            this.groupBox1.Controls.Add(this.txtChange);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSegApellido);
            this.groupBox1.Controls.Add(this.txtPriApellido);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(707, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // lblRiesgo
            // 
            this.lblRiesgo.AutoSize = true;
            this.lblRiesgo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRiesgo.Location = new System.Drawing.Point(35, 392);
            this.lblRiesgo.Name = "lblRiesgo";
            this.lblRiesgo.Size = new System.Drawing.Size(215, 34);
            this.lblRiesgo.TabIndex = 21;
            this.lblRiesgo.Text = "Valores admitidos (1 , 2, 3): \r\n1 = Buena / 2 = Regular / 3 = Mala";
            this.lblRiesgo.Visible = false;
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(367, 349);
            this.password2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(300, 34);
            this.password2.TabIndex = 20;
            this.password2.Enter += new System.EventHandler(this.password2_Enter);
            this.password2.Leave += new System.EventHandler(this.password2_Leave);
            // 
            // password1
            // 
            this.password1.HidePromptOnLeave = true;
            this.password1.Location = new System.Drawing.Point(367, 267);
            this.password1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(300, 34);
            this.password1.TabIndex = 19;
            this.password1.Enter += new System.EventHandler(this.password1_Enter);
            this.password1.Leave += new System.EventHandler(this.password1_Leave);
            // 
            // typePerson
            // 
            this.typePerson.FormattingEnabled = true;
            this.typePerson.Items.AddRange(new object[] {
            "Prestamista",
            "Deudor"});
            this.typePerson.Location = new System.Drawing.Point(33, 267);
            this.typePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typePerson.Name = "typePerson";
            this.typePerson.Size = new System.Drawing.Size(297, 36);
            this.typePerson.TabIndex = 18;
            this.typePerson.SelectedIndexChanged += new System.EventHandler(this.typePerson_SelectedIndexChanged);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(33, 317);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(52, 23);
            this.lblChange.TabIndex = 17;
            this.lblChange.Text = "Saldo";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(30, 349);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(300, 34);
            this.txtChange.TabIndex = 16;
            this.txtChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChange_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo afiliación";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(368, 446);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(300, 40);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(30, 446);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(300, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(367, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(367, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(367, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segundo Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(367, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 34);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(367, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula";
            // 
            // txtSegApellido
            // 
            this.txtSegApellido.Location = new System.Drawing.Point(367, 176);
            this.txtSegApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegApellido.Name = "txtSegApellido";
            this.txtSegApellido.Size = new System.Drawing.Size(300, 34);
            this.txtSegApellido.TabIndex = 2;
            // 
            // txtPriApellido
            // 
            this.txtPriApellido.Location = new System.Drawing.Point(30, 176);
            this.txtPriApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriApellido.Name = "txtPriApellido";
            this.txtPriApellido.Size = new System.Drawing.Size(300, 34);
            this.txtPriApellido.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(33, 78);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(297, 34);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 532);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSegApellido;
        private TextBox txtPriApellido;
        private TextBox txtCedula;
        private Button btnRegistrar;
        private Label label7;
        private TextBox txtChange;
        private Label lblChange;
        private ComboBox typePerson;
        private MaskedTextBox password1;
        private MaskedTextBox password2;
        private Label lblRiesgo;
    }
}