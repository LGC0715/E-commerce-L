
namespace Ecommerce.Formularios.editar
{
    partial class FrmEditarVendas
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
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.txtStatusVenda = new System.Windows.Forms.TextBox();
            this.cbxformapag = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dtgridProdutos = new System.Windows.Forms.DataGridView();
            this.dtgridVendaProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVendaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(255, 622);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(143, 33);
            this.btn_Excluir.TabIndex = 73;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(97, 619);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(128, 36);
            this.btn_Salvar.TabIndex = 72;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(111, 474);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(273, 31);
            this.txtDesconto.TabIndex = 70;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(111, 305);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(273, 31);
            this.txtTotal.TabIndex = 63;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Location = new System.Drawing.Point(111, 220);
            this.txtDataVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(273, 31);
            this.txtDataVenda.TabIndex = 62;
            // 
            // txtStatusVenda
            // 
            this.txtStatusVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusVenda.Location = new System.Drawing.Point(111, 556);
            this.txtStatusVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtStatusVenda.Name = "txtStatusVenda";
            this.txtStatusVenda.Size = new System.Drawing.Size(273, 31);
            this.txtStatusVenda.TabIndex = 74;
            // 
            // cbxformapag
            // 
            this.cbxformapag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxformapag.FormattingEnabled = true;
            this.cbxformapag.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Dinheiro",
            "Pix"});
            this.cbxformapag.Location = new System.Drawing.Point(111, 382);
            this.cbxformapag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxformapag.Name = "cbxformapag";
            this.cbxformapag.Size = new System.Drawing.Size(273, 33);
            this.cbxformapag.TabIndex = 92;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(151, 133);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 31);
            this.txtId.TabIndex = 93;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(768, 26);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(415, 31);
            this.txtpesquisa.TabIndex = 94;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // dtgridProdutos
            // 
            this.dtgridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtgridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridProdutos.Location = new System.Drawing.Point(577, 70);
            this.dtgridProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgridProdutos.Name = "dtgridProdutos";
            this.dtgridProdutos.RowHeadersWidth = 51;
            this.dtgridProdutos.Size = new System.Drawing.Size(636, 286);
            this.dtgridProdutos.TabIndex = 95;
            this.dtgridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridProdutos_CellContentClick);
            this.dtgridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridProdutos_CellDoubleClick);
            // 
            // dtgridVendaProduto
            // 
            this.dtgridVendaProduto.BackgroundColor = System.Drawing.Color.White;
            this.dtgridVendaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVendaProduto.Location = new System.Drawing.Point(577, 382);
            this.dtgridVendaProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgridVendaProduto.Name = "dtgridVendaProduto";
            this.dtgridVendaProduto.RowHeadersWidth = 51;
            this.dtgridVendaProduto.Size = new System.Drawing.Size(636, 293);
            this.dtgridVendaProduto.TabIndex = 96;
            this.dtgridVendaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVendaProduto_CellContentClick);
            this.dtgridVendaProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVendaProduto_CellDoubleClick);
            // 
            // FrmEditarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ecommerce.Properties.Resources.vendas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 681);
            this.Controls.Add(this.dtgridVendaProduto);
            this.Controls.Add(this.dtgridProdutos);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbxformapag);
            this.Controls.Add(this.txtStatusVenda);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDataVenda);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEditarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  EDITAR VENDAS";
            this.Load += new System.EventHandler(this.FrmEditarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVendaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.TextBox txtStatusVenda;
        private System.Windows.Forms.ComboBox cbxformapag;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dtgridProdutos;
        private System.Windows.Forms.DataGridView dtgridVendaProduto;
    }
}