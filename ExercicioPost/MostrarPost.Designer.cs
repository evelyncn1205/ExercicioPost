namespace ExercicioPost
{
    partial class MostrarPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarPost));
            this.btn_NaoGosto = new System.Windows.Forms.Button();
            this.btn_Gosto = new System.Windows.Forms.Button();
            this.lbl_NumNaoGosto = new System.Windows.Forms.Label();
            this.lbl_NumGosto = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_MostrarDescricao = new System.Windows.Forms.Label();
            this.lbl_MostrarTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NaoGosto
            // 
            this.btn_NaoGosto.Image = ((System.Drawing.Image)(resources.GetObject("btn_NaoGosto.Image")));
            this.btn_NaoGosto.Location = new System.Drawing.Point(352, 285);
            this.btn_NaoGosto.Name = "btn_NaoGosto";
            this.btn_NaoGosto.Size = new System.Drawing.Size(94, 74);
            this.btn_NaoGosto.TabIndex = 2;
            this.btn_NaoGosto.UseVisualStyleBackColor = true;
            this.btn_NaoGosto.Click += new System.EventHandler(this.btn_NaoGosto_Click);
            // 
            // btn_Gosto
            // 
            this.btn_Gosto.Image = ((System.Drawing.Image)(resources.GetObject("btn_Gosto.Image")));
            this.btn_Gosto.Location = new System.Drawing.Point(127, 285);
            this.btn_Gosto.Name = "btn_Gosto";
            this.btn_Gosto.Size = new System.Drawing.Size(86, 74);
            this.btn_Gosto.TabIndex = 3;
            this.btn_Gosto.UseVisualStyleBackColor = true;
            this.btn_Gosto.Click += new System.EventHandler(this.btn_Gosto_Click);
            // 
            // lbl_NumNaoGosto
            // 
            this.lbl_NumNaoGosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NumNaoGosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumNaoGosto.Location = new System.Drawing.Point(363, 372);
            this.lbl_NumNaoGosto.Name = "lbl_NumNaoGosto";
            this.lbl_NumNaoGosto.Size = new System.Drawing.Size(64, 33);
            this.lbl_NumNaoGosto.TabIndex = 4;
            this.lbl_NumNaoGosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NumGosto
            // 
            this.lbl_NumGosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NumGosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumGosto.Location = new System.Drawing.Point(138, 372);
            this.lbl_NumGosto.Name = "lbl_NumGosto";
            this.lbl_NumGosto.Size = new System.Drawing.Size(64, 33);
            this.lbl_NumGosto.TabIndex = 5;
            this.lbl_NumGosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Data
            // 
            this.lbl_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Data.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(238, 223);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(100, 23);
            this.lbl_Data.TabIndex = 6;
            this.lbl_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MostrarDescricao
            // 
            this.lbl_MostrarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MostrarDescricao.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MostrarDescricao.Location = new System.Drawing.Point(102, 82);
            this.lbl_MostrarDescricao.Name = "lbl_MostrarDescricao";
            this.lbl_MostrarDescricao.Size = new System.Drawing.Size(366, 126);
            this.lbl_MostrarDescricao.TabIndex = 1;
            // 
            // lbl_MostrarTitulo
            // 
            this.lbl_MostrarTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MostrarTitulo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MostrarTitulo.Location = new System.Drawing.Point(102, 20);
            this.lbl_MostrarTitulo.Name = "lbl_MostrarTitulo";
            this.lbl_MostrarTitulo.Size = new System.Drawing.Size(366, 45);
            this.lbl_MostrarTitulo.TabIndex = 0;
            this.lbl_MostrarTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MostrarPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(585, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_NumGosto);
            this.Controls.Add(this.lbl_NumNaoGosto);
            this.Controls.Add(this.btn_Gosto);
            this.Controls.Add(this.btn_NaoGosto);
            this.Controls.Add(this.lbl_MostrarDescricao);
            this.Controls.Add(this.lbl_MostrarTitulo);
            this.MaximizeBox = false;
            this.Name = "MostrarPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Post";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_NaoGosto;
        private System.Windows.Forms.Button btn_Gosto;
        private System.Windows.Forms.Label lbl_NumNaoGosto;
        private System.Windows.Forms.Label lbl_NumGosto;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_MostrarDescricao;
        private System.Windows.Forms.Label lbl_MostrarTitulo;
        private System.Windows.Forms.Label label1;
    }
}