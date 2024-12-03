
namespace Ecommerce.Formularios
{
    partial class FrmProdutos
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
            this.btnadd_produto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dtGridProdutos = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd_produto
            // 
            this.btnadd_produto.Location = new System.Drawing.Point(25, 13);
            this.btnadd_produto.Name = "btnadd_produto";
            this.btnadd_produto.Size = new System.Drawing.Size(168, 23);
            this.btnadd_produto.TabIndex = 19;
            this.btnadd_produto.Text = "Cadastrar Produtos";
            this.btnadd_produto.UseVisualStyleBackColor = true;
            this.btnadd_produto.Click += new System.EventHandler(this.btnadd_disc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, -13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pesquisar";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(475, 18);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(297, 20);
            this.txtpesquisa.TabIndex = 17;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // dtGridProdutos
            // 
            this.dtGridProdutos.AllowUserToAddRows = false;
            this.dtGridProdutos.AllowUserToDeleteRows = false;
            this.dtGridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdutos.Location = new System.Drawing.Point(15, 64);
            this.dtGridProdutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtGridProdutos.Name = "dtGridProdutos";
            this.dtGridProdutos.ReadOnly = true;
            this.dtGridProdutos.RowHeadersWidth = 51;
            this.dtGridProdutos.Size = new System.Drawing.Size(770, 400);
            this.dtGridProdutos.TabIndex = 16;
            this.dtGridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProdutos_CellContentClick);
            this.dtGridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProdutos_CellDoubleClick);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(416, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 13);
            this.txtId.TabIndex = 68;
            this.txtId.Text = "Pesquisar:";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnadd_produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.dtGridProdutos);
            this.Name = "FrmProdutos";
            this.Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dtGridProdutos;
        private System.Windows.Forms.Label txtId;
    }
}