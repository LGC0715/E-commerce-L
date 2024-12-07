
namespace Ecommerce.Formularios.cadastrar
{
    partial class FrmCadastrarVendas
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
            this.txtStatusVenda = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.btncadastro = new System.Windows.Forms.Button();
            this.cbxformapag = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtStatusVenda
            // 
            this.txtStatusVenda.Location = new System.Drawing.Point(36, 343);
            this.txtStatusVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtStatusVenda.Name = "txtStatusVenda";
            this.txtStatusVenda.Size = new System.Drawing.Size(244, 22);
            this.txtStatusVenda.TabIndex = 88;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(36, 280);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(244, 22);
            this.txtDesconto.TabIndex = 84;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(36, 166);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(244, 22);
            this.txtTotal.TabIndex = 77;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(36, 111);
            this.txtDataVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(244, 22);
            this.txtDataVenda.TabIndex = 76;
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(59, 406);
            this.btncadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(173, 28);
            this.btncadastro.TabIndex = 90;
            this.btncadastro.Text = "Cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // cbxformapag
            // 
            this.cbxformapag.FormattingEnabled = true;
            this.cbxformapag.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Dinheiro",
            "Pix"});
            this.cbxformapag.Location = new System.Drawing.Point(36, 222);
            this.cbxformapag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxformapag.Name = "cbxformapag";
            this.cbxformapag.Size = new System.Drawing.Size(244, 24);
            this.cbxformapag.TabIndex = 91;
            // 
            // FrmCadastrarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ecommerce.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 482);
            this.Controls.Add(this.cbxformapag);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.txtStatusVenda);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDataVenda);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCadastrarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR VENDAS";
            this.Load += new System.EventHandler(this.FrmCadastrarVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStatusVenda;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.ComboBox cbxformapag;
    }
}