namespace N2
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.buttonJogar = new System.Windows.Forms.Button();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.buttonRecordes = new System.Windows.Forms.Button();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSound = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJogar
            // 
            this.buttonJogar.BackgroundImage = global::N2.Properties.Resources.Jogar;
            this.buttonJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJogar.Location = new System.Drawing.Point(339, 173);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(90, 35);
            this.buttonJogar.TabIndex = 0;
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.BackgroundImage = global::N2.Properties.Resources.Cadastro1;
            this.buttonCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCadastro.Location = new System.Drawing.Point(339, 255);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(90, 35);
            this.buttonCadastro.TabIndex = 2;
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // buttonRecordes
            // 
            this.buttonRecordes.BackgroundImage = global::N2.Properties.Resources.recordes;
            this.buttonRecordes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRecordes.Location = new System.Drawing.Point(339, 214);
            this.buttonRecordes.Name = "buttonRecordes";
            this.buttonRecordes.Size = new System.Drawing.Size(90, 35);
            this.buttonRecordes.TabIndex = 1;
            this.buttonRecordes.UseVisualStyleBackColor = true;
            this.buttonRecordes.Click += new System.EventHandler(this.buttonRecordes_Click);
            // 
            // buttonSobre
            // 
            this.buttonSobre.BackgroundImage = global::N2.Properties.Resources.sobre;
            this.buttonSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSobre.Location = new System.Drawing.Point(339, 296);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(90, 35);
            this.buttonSobre.TabIndex = 3;
            this.buttonSobre.UseVisualStyleBackColor = true;
            this.buttonSobre.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImage = global::N2.Properties.Resources.sair;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.Location = new System.Drawing.Point(339, 337);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(90, 35);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonSound
            // 
            this.buttonSound.BackgroundImage = global::N2.Properties.Resources.soundOn;
            this.buttonSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSound.Location = new System.Drawing.Point(404, 12);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(36, 35);
            this.buttonSound.TabIndex = 5;
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::N2.Properties.Resources.ezgif1;
            this.pictureBox1.Location = new System.Drawing.Point(86, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "By Deivid Cardoso, 2016";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::N2.Properties.Resources.capa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSobre);
            this.Controls.Add(this.buttonRecordes);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.buttonJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Hangman Game";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJogar;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.Button buttonRecordes;
        private System.Windows.Forms.Button buttonSobre;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

