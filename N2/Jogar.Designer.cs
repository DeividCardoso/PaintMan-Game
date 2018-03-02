namespace N2
{
    partial class Jogar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogar));
            this.timerDaAnimacao = new System.Windows.Forms.Timer(this.components);
            this.btnDica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSortearPalavra = new System.Windows.Forms.Button();
            this.cmbEscolhaTema = new System.Windows.Forms.ComboBox();
            this.txtDica = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.MaskedTextBox();
            this.txtLetras = new System.Windows.Forms.Label();
            this.lblChances = new System.Windows.Forms.Label();
            this.txtChances = new System.Windows.Forms.TextBox();
            this.timerDoJogo = new System.Windows.Forms.Timer(this.components);
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.picLetras = new System.Windows.Forms.PictureBox();
            this.picSeta = new System.Windows.Forms.PictureBox();
            this.buttonSound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDaAnimacao
            // 
            this.timerDaAnimacao.Tick += new System.EventHandler(this.timerDaAnimacao_Tick);
            // 
            // btnDica
            // 
            this.btnDica.Enabled = false;
            this.btnDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDica.Location = new System.Drawing.Point(287, 26);
            this.btnDica.Name = "btnDica";
            this.btnDica.Size = new System.Drawing.Size(52, 25);
            this.btnDica.TabIndex = 2;
            this.btnDica.TabStop = false;
            this.btnDica.Text = "Dica";
            this.btnDica.UseVisualStyleBackColor = true;
            this.btnDica.Visible = false;
            this.btnDica.Click += new System.EventHandler(this.btnDica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Escolha um Tema";
            // 
            // btnSortearPalavra
            // 
            this.btnSortearPalavra.Enabled = false;
            this.btnSortearPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortearPalavra.Location = new System.Drawing.Point(155, 26);
            this.btnSortearPalavra.Name = "btnSortearPalavra";
            this.btnSortearPalavra.Size = new System.Drawing.Size(110, 24);
            this.btnSortearPalavra.TabIndex = 1;
            this.btnSortearPalavra.Text = "Começar Jogo";
            this.btnSortearPalavra.UseVisualStyleBackColor = true;
            this.btnSortearPalavra.Click += new System.EventHandler(this.btnSortearPalavra_Click);
            // 
            // cmbEscolhaTema
            // 
            this.cmbEscolhaTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscolhaTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEscolhaTema.FormattingEnabled = true;
            this.cmbEscolhaTema.Location = new System.Drawing.Point(12, 26);
            this.cmbEscolhaTema.Name = "cmbEscolhaTema";
            this.cmbEscolhaTema.Size = new System.Drawing.Size(121, 24);
            this.cmbEscolhaTema.TabIndex = 0;
            this.cmbEscolhaTema.SelectedIndexChanged += new System.EventHandler(this.cmbEscolhaTema_SelectedIndexChanged);
            // 
            // txtDica
            // 
            this.txtDica.BackColor = System.Drawing.SystemColors.Window;
            this.txtDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDica.Location = new System.Drawing.Point(345, 25);
            this.txtDica.Multiline = true;
            this.txtDica.Name = "txtDica";
            this.txtDica.ReadOnly = true;
            this.txtDica.Size = new System.Drawing.Size(158, 50);
            this.txtDica.TabIndex = 30;
            this.txtDica.Visible = false;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(449, 114);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(71, 24);
            this.lblTempo.TabIndex = 31;
            this.lblTempo.Text = "Tempo";
            this.lblTempo.Visible = false;
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(520, 107);
            this.txtTempo.Mask = "000 sec";
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.ReadOnly = true;
            this.txtTempo.Size = new System.Drawing.Size(74, 29);
            this.txtTempo.TabIndex = 32;
            this.txtTempo.TabStop = false;
            this.txtTempo.Text = "100";
            this.txtTempo.Visible = false;
            // 
            // txtLetras
            // 
            this.txtLetras.Enabled = false;
            this.txtLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetras.Location = new System.Drawing.Point(258, 159);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(336, 33);
            this.txtLetras.TabIndex = 34;
            this.txtLetras.UseWaitCursor = true;
            this.txtLetras.Visible = false;
            // 
            // lblChances
            // 
            this.lblChances.AutoSize = true;
            this.lblChances.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChances.Location = new System.Drawing.Point(283, 114);
            this.lblChances.Name = "lblChances";
            this.lblChances.Size = new System.Drawing.Size(85, 24);
            this.lblChances.TabIndex = 35;
            this.lblChances.Text = "Chances";
            this.lblChances.UseWaitCursor = true;
            this.lblChances.Visible = false;
            // 
            // txtChances
            // 
            this.txtChances.BackColor = System.Drawing.SystemColors.Window;
            this.txtChances.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChances.Location = new System.Drawing.Point(369, 107);
            this.txtChances.Name = "txtChances";
            this.txtChances.ReadOnly = true;
            this.txtChances.Size = new System.Drawing.Size(30, 29);
            this.txtChances.TabIndex = 36;
            this.txtChances.TabStop = false;
            this.txtChances.Text = "5";
            this.txtChances.Visible = false;
            // 
            // timerDoJogo
            // 
            this.timerDoJogo.Tick += new System.EventHandler(this.timerDoJogo_Tick);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(506, 411);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(0, 24);
            this.lblQuantidade.TabIndex = 37;
            this.lblQuantidade.Visible = false;
            // 
            // picLetras
            // 
            this.picLetras.BackgroundImage = global::N2.Properties.Resources.Letras;
            this.picLetras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLetras.Location = new System.Drawing.Point(155, 159);
            this.picLetras.Name = "picLetras";
            this.picLetras.Size = new System.Drawing.Size(100, 33);
            this.picLetras.TabIndex = 33;
            this.picLetras.TabStop = false;
            this.picLetras.Visible = false;
            // 
            // picSeta
            // 
            this.picSeta.Image = global::N2.Properties.Resources.Seta;
            this.picSeta.Location = new System.Drawing.Point(16, 49);
            this.picSeta.Name = "picSeta";
            this.picSeta.Size = new System.Drawing.Size(51, 162);
            this.picSeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeta.TabIndex = 28;
            this.picSeta.TabStop = false;
            // 
            // buttonSound
            // 
            this.buttonSound.BackgroundImage = global::N2.Properties.Resources.soundOn;
            this.buttonSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSound.Location = new System.Drawing.Point(549, 19);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(36, 35);
            this.buttonSound.TabIndex = 3;
            this.buttonSound.TabStop = false;
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // Jogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(599, 559);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtChances);
            this.Controls.Add(this.lblChances);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.picLetras);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtDica);
            this.Controls.Add(this.cmbEscolhaTema);
            this.Controls.Add(this.picSeta);
            this.Controls.Add(this.btnSortearPalavra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.btnDica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Hangman Game";
            this.Load += new System.EventHandler(this.Jogar_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jogar_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerDaAnimacao;
        private System.Windows.Forms.Button btnDica;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortearPalavra;
        private System.Windows.Forms.PictureBox picSeta;
        private System.Windows.Forms.ComboBox cmbEscolhaTema;
        private System.Windows.Forms.TextBox txtDica;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.MaskedTextBox txtTempo;
        private System.Windows.Forms.PictureBox picLetras;
        private System.Windows.Forms.Label txtLetras;
        private System.Windows.Forms.Label lblChances;
        private System.Windows.Forms.TextBox txtChances;
        private System.Windows.Forms.Timer timerDoJogo;
        private System.Windows.Forms.Label lblQuantidade;
    }
}