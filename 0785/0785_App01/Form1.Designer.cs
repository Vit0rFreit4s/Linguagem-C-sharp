namespace _0785_App01
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.SystemColors.Info;
            this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.Color.Navy;
            this.txt_1.Location = new System.Drawing.Point(12, 31);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(280, 26);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_1.Location = new System.Drawing.Point(312, 20);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(128, 46);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "Clique aqui!";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_1.Location = new System.Drawing.Point(12, 140);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(280, 40);
            this.lbl_1.TabIndex = 2;
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_2.Location = new System.Drawing.Point(312, 140);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(128, 40);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Clear";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_1);
            this.Name = "Form1";
            this.Text = "APP 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_2;
    }
}

