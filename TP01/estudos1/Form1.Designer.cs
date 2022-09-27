namespace estudos1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_R1 = new System.Windows.Forms.TextBox();
            this.TXT_R2 = new System.Windows.Forms.TextBox();
            this.TXT_R3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_LIMPAR = new System.Windows.Forms.Button();
            this.BTN_SAIR = new System.Windows.Forms.Button();
            this.TXT_CALCULAR = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TXT_R1
            // 
            this.TXT_R1.Location = new System.Drawing.Point(358, 38);
            this.TXT_R1.Name = "TXT_R1";
            this.TXT_R1.Size = new System.Drawing.Size(76, 20);
            this.TXT_R1.TabIndex = 1;
            this.TXT_R1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXT_R2
            // 
            this.TXT_R2.Location = new System.Drawing.Point(358, 81);
            this.TXT_R2.Name = "TXT_R2";
            this.TXT_R2.Size = new System.Drawing.Size(76, 20);
            this.TXT_R2.TabIndex = 2;
            // 
            // TXT_R3
            // 
            this.TXT_R3.Location = new System.Drawing.Point(358, 117);
            this.TXT_R3.Name = "TXT_R3";
            this.TXT_R3.Size = new System.Drawing.Size(76, 20);
            this.TXT_R3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "R3";
            // 
            // BTN_LIMPAR
            // 
            this.BTN_LIMPAR.Location = new System.Drawing.Point(62, 205);
            this.BTN_LIMPAR.Name = "BTN_LIMPAR";
            this.BTN_LIMPAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_LIMPAR.TabIndex = 7;
            this.BTN_LIMPAR.Text = "LIMPAR";
            this.BTN_LIMPAR.UseVisualStyleBackColor = true;
            this.BTN_LIMPAR.Click += new System.EventHandler(this.BTN_LIMPAR_Click);
            // 
            // BTN_SAIR
            // 
            this.BTN_SAIR.Location = new System.Drawing.Point(190, 205);
            this.BTN_SAIR.Name = "BTN_SAIR";
            this.BTN_SAIR.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAIR.TabIndex = 8;
            this.BTN_SAIR.Text = "SAIR";
            this.BTN_SAIR.UseVisualStyleBackColor = true;
            this.BTN_SAIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_CALCULAR
            // 
            this.TXT_CALCULAR.Location = new System.Drawing.Point(326, 205);
            this.TXT_CALCULAR.Name = "TXT_CALCULAR";
            this.TXT_CALCULAR.Size = new System.Drawing.Size(75, 23);
            this.TXT_CALCULAR.TabIndex = 9;
            this.TXT_CALCULAR.Text = "CALCULAR";
            this.TXT_CALCULAR.UseVisualStyleBackColor = true;
            this.TXT_CALCULAR.Click += new System.EventHandler(this.TXT_CALCULAR_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(137, 157);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 299);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.TXT_CALCULAR);
            this.Controls.Add(this.BTN_SAIR);
            this.Controls.Add(this.BTN_LIMPAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_R3);
            this.Controls.Add(this.TXT_R2);
            this.Controls.Add(this.TXT_R1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "DELTA PARA Y";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_R1;
        private System.Windows.Forms.TextBox TXT_R2;
        private System.Windows.Forms.TextBox TXT_R3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_LIMPAR;
        private System.Windows.Forms.Button BTN_SAIR;
        private System.Windows.Forms.Button TXT_CALCULAR;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

