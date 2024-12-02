
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatusVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.btncadastro = new System.Windows.Forms.Button();
            this.cbxformapag = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Status Venda";
            // 
            // txtStatusVenda
            // 
            this.txtStatusVenda.Location = new System.Drawing.Point(31, 379);
            this.txtStatusVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtStatusVenda.Name = "txtStatusVenda";
            this.txtStatusVenda.Size = new System.Drawing.Size(244, 22);
            this.txtStatusVenda.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(33, 320);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(244, 22);
            this.txtDesconto.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 83;
            this.label5.Text = "Forma de Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Data Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(33, 177);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(244, 22);
            this.txtTotal.TabIndex = 77;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(34, 100);
            this.txtDataVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(243, 22);
            this.txtDataVenda.TabIndex = 76;
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(55, 420);
            this.btncadastro.Margin = new System.Windows.Forms.Padding(4);
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
            this.cbxformapag.Location = new System.Drawing.Point(29, 262);
            this.cbxformapag.Name = "cbxformapag";
            this.cbxformapag.Size = new System.Drawing.Size(246, 24);
            this.cbxformapag.TabIndex = 91;
            // 
            // FrmCadastrarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 482);
            this.Controls.Add(this.cbxformapag);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatusVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDataVenda);
            this.Name = "FrmCadastrarVendas";
            this.Text = "FrmCadastrarVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatusVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.ComboBox cbxformapag;
    }
}