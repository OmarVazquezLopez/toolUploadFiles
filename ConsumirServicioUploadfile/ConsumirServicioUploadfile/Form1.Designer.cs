namespace ConsumirServicioUploadfile
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLlamarToken = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.txtIngresarToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCargarArchivos = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLlamarToken
            // 
            this.btnLlamarToken.Location = new System.Drawing.Point(198, 125);
            this.btnLlamarToken.Name = "btnLlamarToken";
            this.btnLlamarToken.Size = new System.Drawing.Size(119, 37);
            this.btnLlamarToken.TabIndex = 0;
            this.btnLlamarToken.Text = "Generar token";
            this.btnLlamarToken.UseVisualStyleBackColor = true;
            this.btnLlamarToken.Click += new System.EventHandler(this.btnLlamarToken_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(12, 289);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(119, 37);
            this.btnCargarArchivo.TabIndex = 2;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // txtIngresarToken
            // 
            this.txtIngresarToken.Location = new System.Drawing.Point(198, 205);
            this.txtIngresarToken.Name = "txtIngresarToken";
            this.txtIngresarToken.Size = new System.Drawing.Size(590, 20);
            this.txtIngresarToken.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "ToolUploadFiles";
            // 
            // txtIngresarArchivo
            // 
            this.txtIngresarArchivo.Location = new System.Drawing.Point(198, 246);
            this.txtIngresarArchivo.Name = "txtIngresarArchivo";
            this.txtIngresarArchivo.Size = new System.Drawing.Size(590, 20);
            this.txtIngresarArchivo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingresar token: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingresar nombre archivo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Token: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(138, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(997, 186);
            this.listBox1.TabIndex = 9;
            // 
            // btnCargarArchivos
            // 
            this.btnCargarArchivos.Enabled = false;
            this.btnCargarArchivos.Location = new System.Drawing.Point(12, 383);
            this.btnCargarArchivos.Name = "btnCargarArchivos";
            this.btnCargarArchivos.Size = new System.Drawing.Size(119, 37);
            this.btnCargarArchivos.TabIndex = 10;
            this.btnCargarArchivos.Text = "Cargar Archivos";
            this.btnCargarArchivos.UseVisualStyleBackColor = true;
            this.btnCargarArchivos.Click += new System.EventHandler(this.btnCargarArchivos_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 348);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Cargar varios archivos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(906, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1147, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCargarArchivos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngresarArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngresarToken);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLlamarToken);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ToolUploadFiles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamarToken;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.TextBox txtIngresarToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCargarArchivos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

