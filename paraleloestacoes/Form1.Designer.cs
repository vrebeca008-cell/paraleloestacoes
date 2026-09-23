namespace paraleloestacoes
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
			this.Rad_primeiro = new System.Windows.Forms.RadioButton();
			this.Txt_primeiro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Pic_primeiro = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Pic_primeiro)).BeginInit();
			this.SuspendLayout();
			// 
			// Rad_primeiro
			// 
			this.Rad_primeiro.AutoSize = true;
			this.Rad_primeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rad_primeiro.Location = new System.Drawing.Point(52, 555);
			this.Rad_primeiro.Name = "Rad_primeiro";
			this.Rad_primeiro.Size = new System.Drawing.Size(83, 20);
			this.Rad_primeiro.TabIndex = 1;
			this.Rad_primeiro.Text = "Primeiro";
			this.Rad_primeiro.UseVisualStyleBackColor = true;
			this.Rad_primeiro.CheckedChanged += new System.EventHandler(this.Rad_primeiro_CheckedChanged);
			// 
			// Txt_primeiro
			// 
			this.Txt_primeiro.Enabled = false;
			this.Txt_primeiro.Location = new System.Drawing.Point(477, 52);
			this.Txt_primeiro.Name = "Txt_primeiro";
			this.Txt_primeiro.Size = new System.Drawing.Size(194, 20);
			this.Txt_primeiro.TabIndex = 2;
			this.Txt_primeiro.TextChanged += new System.EventHandler(this.Txt_primeiro_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(365, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Informações :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Pic_primeiro
			// 
			this.Pic_primeiro.Location = new System.Drawing.Point(301, 79);
			this.Pic_primeiro.Name = "Pic_primeiro";
			this.Pic_primeiro.Size = new System.Drawing.Size(475, 511);
			this.Pic_primeiro.TabIndex = 0;
			this.Pic_primeiro.TabStop = false;
			this.Pic_primeiro.Click += new System.EventHandler(this.Pic_primeiro_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 602);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Txt_primeiro);
			this.Controls.Add(this.Rad_primeiro);
			this.Controls.Add(this.Pic_primeiro);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.Pic_primeiro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_primeiro;
        private System.Windows.Forms.RadioButton Rad_primeiro;
        private System.Windows.Forms.TextBox Txt_primeiro;
        private System.Windows.Forms.Label label1;
    }
}

