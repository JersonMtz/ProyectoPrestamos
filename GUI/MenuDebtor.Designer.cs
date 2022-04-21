namespace ProyectoPrestamos
{
    partial class MenuDebtor
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listaPrestamos = new System.Windows.Forms.DataGridView();
            this.lblValorRiesgo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Préstamos solicitados";
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.Location = new System.Drawing.Point(817, 143);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(129, 54);
            this.btnPrestamo.TabIndex = 17;
            this.btnPrestamo.Text = "Nuevo \r\nPrestamo";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(817, 36);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 41);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listaPrestamos
            // 
            this.listaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPrestamos.Location = new System.Drawing.Point(15, 227);
            this.listaPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.listaPrestamos.Name = "listaPrestamos";
            this.listaPrestamos.RowHeadersWidth = 51;
            this.listaPrestamos.RowTemplate.Height = 29;
            this.listaPrestamos.Size = new System.Drawing.Size(931, 392);
            this.listaPrestamos.TabIndex = 15;
            // 
            // lblValorRiesgo
            // 
            this.lblValorRiesgo.AutoSize = true;
            this.lblValorRiesgo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorRiesgo.Location = new System.Drawing.Point(182, 87);
            this.lblValorRiesgo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorRiesgo.Name = "lblValorRiesgo";
            this.lblValorRiesgo.Size = new System.Drawing.Size(35, 41);
            this.lblValorRiesgo.TabIndex = 14;
            this.lblValorRiesgo.Text = "1";
            this.lblValorRiesgo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor riesgo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(110, 26);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(182, 41);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Fulanito XX";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario:";
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(818, 94);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(129, 41);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // MenuDebtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 639);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listaPrestamos);
            this.Controls.Add(this.lblValorRiesgo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuDebtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Deudor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuDebtor_FormClosing);
            this.Load += new System.EventHandler(this.MenuDebtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button btnPrestamo;
        private Button btnSalir;
        private DataGridView listaPrestamos;
        private Label lblValorRiesgo;
        private Label label3;
        private Label lblUsuario;
        private Label label1;
        private Button btnListar;
    }
}