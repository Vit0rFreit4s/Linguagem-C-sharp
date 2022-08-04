namespace _0785_App02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_vezes = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1º Número";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(69, 40);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(81, 20);
            this.txt_1.TabIndex = 1;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "2º Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(69, 92);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(81, 20);
            this.txt_2.TabIndex = 1;
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_mais
            // 
            this.btn_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mais.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_mais.Location = new System.Drawing.Point(24, 134);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(32, 31);
            this.btn_mais.TabIndex = 2;
            this.btn_mais.Text = "+";
            this.btn_mais.UseVisualStyleBackColor = true;
            this.btn_mais.Click += new System.EventHandler(this.btn_mais_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menos.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_menos.Location = new System.Drawing.Point(62, 134);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(32, 31);
            this.btn_menos.TabIndex = 2;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.btn_menos_Click);
            // 
            // btn_vezes
            // 
            this.btn_vezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vezes.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_vezes.Location = new System.Drawing.Point(100, 134);
            this.btn_vezes.Name = "btn_vezes";
            this.btn_vezes.Size = new System.Drawing.Size(32, 31);
            this.btn_vezes.TabIndex = 2;
            this.btn_vezes.Text = "*";
            this.btn_vezes.UseVisualStyleBackColor = true;
            this.btn_vezes.Click += new System.EventHandler(this.btn_vezes_Click);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_div.Location = new System.Drawing.Point(138, 134);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(32, 31);
            this.btn_div.TabIndex = 2;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_clear.Location = new System.Drawing.Point(176, 134);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(38, 31);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resultado.Location = new System.Drawing.Point(34, 190);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(149, 32);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 252);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_vezes);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_vezes;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

