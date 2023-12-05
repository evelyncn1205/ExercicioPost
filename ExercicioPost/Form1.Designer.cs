namespace ExercicioPost
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.btn_Postar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.Lbl_titulo.Location = new System.Drawing.Point(25, 74);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(121, 44);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Titulo:";
            this.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Titulo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.Location = new System.Drawing.Point(162, 86);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(290, 26);
            this.txt_Titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Descricao.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descricao.Location = new System.Drawing.Point(162, 141);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(290, 155);
            this.txt_Descricao.TabIndex = 3;
            // 
            // btn_Postar
            // 
            this.btn_Postar.BackColor = System.Drawing.Color.Plum;
            this.btn_Postar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Postar.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Postar.ForeColor = System.Drawing.Color.Black;
            this.btn_Postar.Location = new System.Drawing.Point(231, 312);
            this.btn_Postar.Name = "btn_Postar";
            this.btn_Postar.Size = new System.Drawing.Size(153, 74);
            this.btn_Postar.TabIndex = 4;
            this.btn_Postar.Text = "Postar";
            this.btn_Postar.UseVisualStyleBackColor = false;
            this.btn_Postar.Click += new System.EventHandler(this.btn_Postar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Em que estás a pensar?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(584, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Postar);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Button btn_Postar;
        private System.Windows.Forms.Label label2;
    }
}

