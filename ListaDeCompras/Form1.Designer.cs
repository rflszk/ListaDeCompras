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
            this.PibLogo = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNomeProduto = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LibCompras = new System.Windows.Forms.ListBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PibLogo
            // 
            this.PibLogo.Image = global::ListaDeCompras.Properties.Resources.Logo;
            this.PibLogo.Location = new System.Drawing.Point(188, 33);
            this.PibLogo.Name = "PibLogo";
            this.PibLogo.Size = new System.Drawing.Size(80, 97);
            this.PibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PibLogo.TabIndex = 0;
            this.PibLogo.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("SansSerif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblTitulo.Location = new System.Drawing.Point(273, 49);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(297, 41);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Lista De Compras";
            // 
            // LblNomeProduto
            // 
            this.LblNomeProduto.AutoSize = true;
            this.LblNomeProduto.Location = new System.Drawing.Point(130, 222);
            this.LblNomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNomeProduto.Name = "LblNomeProduto";
            this.LblNomeProduto.Size = new System.Drawing.Size(138, 19);
            this.LblNomeProduto.TabIndex = 2;
            this.LblNomeProduto.Text = "Nome do Produto:";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.Location = new System.Drawing.Point(280, 219);
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(290, 26);
            this.TxtNomeProduto.TabIndex = 3;
            this.TxtNomeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomeProduto_KeyDown);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(134, 269);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(436, 44);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LibCompras
            // 
            this.LibCompras.FormattingEnabled = true;
            this.LibCompras.ItemHeight = 19;
            this.LibCompras.Location = new System.Drawing.Point(134, 339);
            this.LibCompras.Name = "LibCompras";
            this.LibCompras.Size = new System.Drawing.Size(436, 118);
            this.LibCompras.TabIndex = 5;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(134, 478);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(214, 41);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "Excluir Item";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(356, 478);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(214, 41);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar Lista";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 589);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.LibCompras);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtNomeProduto);
            this.Controls.Add(this.LblNomeProduto);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PibLogo);
            this.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Lista De Compras ::";
            ((System.ComponentModel.ISupportInitialize)(this.PibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PibLogo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNomeProduto;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LibCompras;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

