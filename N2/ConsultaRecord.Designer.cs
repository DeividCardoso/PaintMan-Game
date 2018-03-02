namespace N2
{
    partial class ConsultaRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRecord));
            this.dtGridRecordes = new System.Windows.Forms.DataGridView();
            this.Posição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Palavra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRecordes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridRecordes
            // 
            this.dtGridRecordes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridRecordes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posição,
            this.Jogador,
            this.Tempo,
            this.Palavra});
            this.dtGridRecordes.Location = new System.Drawing.Point(9, 12);
            this.dtGridRecordes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGridRecordes.Name = "dtGridRecordes";
            this.dtGridRecordes.ReadOnly = true;
            this.dtGridRecordes.Size = new System.Drawing.Size(487, 405);
            this.dtGridRecordes.TabIndex = 0;
            // 
            // Posição
            // 
            this.Posição.HeaderText = "Posicao";
            this.Posição.Name = "Posição";
            this.Posição.ReadOnly = true;
            this.Posição.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Posição.Width = 65;
            // 
            // Jogador
            // 
            this.Jogador.HeaderText = "Jogador";
            this.Jogador.Name = "Jogador";
            this.Jogador.ReadOnly = true;
            this.Jogador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Jogador.Width = 130;
            // 
            // Tempo
            // 
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            this.Tempo.Width = 130;
            // 
            // Palavra
            // 
            this.Palavra.HeaderText = "Palavra";
            this.Palavra.Name = "Palavra";
            this.Palavra.ReadOnly = true;
            this.Palavra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Palavra.Width = 130;
            // 
            // ConsultaRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 425);
            this.Controls.Add(this.dtGridRecordes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livro dos recordes";
            this.Load += new System.EventHandler(this.ConsultaRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRecordes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridRecordes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palavra;
    }
}