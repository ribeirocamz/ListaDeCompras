namespace ListaDeCompras
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
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.libItens = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::ListaDeCompras.Properties.Resources.logo;
            this.pibLogo.Location = new System.Drawing.Point(192, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(119, 96);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(317, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista de Compras";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(76, 174);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(155, 24);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(80, 211);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(151, 20);
            this.txbProduto.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(80, 248);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(151, 39);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // libItens
            // 
            this.libItens.FormattingEnabled = true;
            this.libItens.ItemHeight = 15;
            this.libItens.Location = new System.Drawing.Point(409, 174);
            this.libItens.Name = "libItens";
            this.libItens.Size = new System.Drawing.Size(330, 259);
            this.libItens.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(409, 439);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 38);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(619, 439);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.libItens);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de compras";
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libItens;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

