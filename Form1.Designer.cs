namespace Espanhol
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_frase = new System.Windows.Forms.Label();
            this.rbx1 = new System.Windows.Forms.RadioButton();
            this.rbx2 = new System.Windows.Forms.RadioButton();
            this.rbx3 = new System.Windows.Forms.RadioButton();
            this.rbx4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(363, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "PROXIMO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_frase
            // 
            this.lbl_frase.AutoSize = true;
            this.lbl_frase.Location = new System.Drawing.Point(152, 108);
            this.lbl_frase.Name = "lbl_frase";
            this.lbl_frase.Size = new System.Drawing.Size(35, 13);
            this.lbl_frase.TabIndex = 1;
            this.lbl_frase.Text = "label1";
            // 
            // rbx1
            // 
            this.rbx1.AutoSize = true;
            this.rbx1.Location = new System.Drawing.Point(155, 145);
            this.rbx1.Name = "rbx1";
            this.rbx1.Size = new System.Drawing.Size(85, 17);
            this.rbx1.TabIndex = 2;
            this.rbx1.TabStop = true;
            this.rbx1.Text = "radioButton1";
            this.rbx1.UseVisualStyleBackColor = true;
            this.rbx1.CheckedChanged += new System.EventHandler(this.rbx1_CheckedChanged);
            // 
            // rbx2
            // 
            this.rbx2.AutoSize = true;
            this.rbx2.Location = new System.Drawing.Point(154, 192);
            this.rbx2.Name = "rbx2";
            this.rbx2.Size = new System.Drawing.Size(85, 17);
            this.rbx2.TabIndex = 3;
            this.rbx2.TabStop = true;
            this.rbx2.Text = "radioButton2";
            this.rbx2.UseVisualStyleBackColor = true;
            // 
            // rbx3
            // 
            this.rbx3.AutoSize = true;
            this.rbx3.Location = new System.Drawing.Point(312, 145);
            this.rbx3.Name = "rbx3";
            this.rbx3.Size = new System.Drawing.Size(85, 17);
            this.rbx3.TabIndex = 4;
            this.rbx3.TabStop = true;
            this.rbx3.Text = "radioButton3";
            this.rbx3.UseVisualStyleBackColor = true;
            // 
            // rbx4
            // 
            this.rbx4.AutoSize = true;
            this.rbx4.Location = new System.Drawing.Point(312, 192);
            this.rbx4.Name = "rbx4";
            this.rbx4.Size = new System.Drawing.Size(85, 17);
            this.rbx4.TabIndex = 5;
            this.rbx4.TabStop = true;
            this.rbx4.Text = "radioButton4";
            this.rbx4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 62);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(451, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESPANHOL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 134);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Black;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(14, 16);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(118, 31);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Location = new System.Drawing.Point(-2, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 72);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbx4);
            this.Controls.Add(this.rbx3);
            this.Controls.Add(this.rbx2);
            this.Controls.Add(this.rbx1);
            this.Controls.Add(this.lbl_frase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_frase;
        private System.Windows.Forms.RadioButton rbx1;
        private System.Windows.Forms.RadioButton rbx2;
        private System.Windows.Forms.RadioButton rbx3;
        private System.Windows.Forms.RadioButton rbx4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
    }
}

