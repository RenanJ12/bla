namespace Aplicações_Matematicas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumtab = new System.Windows.Forms.TextBox();
            this.lsttab = new System.Windows.Forms.ListBox();
            this.btncaltab = new System.Windows.Forms.Button();
            this.btnlimpartab = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1326, 731);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnlimpartab);
            this.tabPage1.Controls.Add(this.btncaltab);
            this.tabPage1.Controls.Add(this.lsttab);
            this.tabPage1.Controls.Add(this.txtnumtab);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1318, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabuada";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Red;
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1318, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fatorial";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1318, 684);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Primo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(314, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabuada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite um número";
            // 
            // txtnumtab
            // 
            this.txtnumtab.Location = new System.Drawing.Point(479, 80);
            this.txtnumtab.MaxLength = 5;
            this.txtnumtab.Name = "txtnumtab";
            this.txtnumtab.Size = new System.Drawing.Size(199, 38);
            this.txtnumtab.TabIndex = 2;
            // 
            // lsttab
            // 
            this.lsttab.FormattingEnabled = true;
            this.lsttab.ItemHeight = 31;
            this.lsttab.Location = new System.Drawing.Point(50, 178);
            this.lsttab.Name = "lsttab";
            this.lsttab.Size = new System.Drawing.Size(360, 469);
            this.lsttab.TabIndex = 3;
            // 
            // btncaltab
            // 
            this.btncaltab.Location = new System.Drawing.Point(479, 221);
            this.btncaltab.Name = "btncaltab";
            this.btncaltab.Size = new System.Drawing.Size(175, 52);
            this.btncaltab.TabIndex = 4;
            this.btncaltab.Text = "Calcular";
            this.btncaltab.UseVisualStyleBackColor = true;
            this.btncaltab.Click += new System.EventHandler(this.btncaltab_Click);
            // 
            // btnlimpartab
            // 
            this.btnlimpartab.Location = new System.Drawing.Point(479, 314);
            this.btnlimpartab.Name = "btnlimpartab";
            this.btnlimpartab.Size = new System.Drawing.Size(175, 52);
            this.btnlimpartab.TabIndex = 5;
            this.btnlimpartab.Text = "Limpar";
            this.btnlimpartab.UseVisualStyleBackColor = true;
            this.btnlimpartab.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicações_Matematicas.Properties.Resources.png_transparent_computer_icons_calculator_calculator_electronics_rectangle_black_thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(768, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 731);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Aplicações Matematicas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnlimpartab;
        private System.Windows.Forms.Button btncaltab;
        private System.Windows.Forms.ListBox lsttab;
        private System.Windows.Forms.TextBox txtnumtab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

