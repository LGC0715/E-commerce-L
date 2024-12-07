
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
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd_produto
            // 
            this.btnadd_produto.Location = new System.Drawing.Point(845, 127);
            this.btnadd_produto.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd_produto.Name = "btnadd_produto";
            this.btnadd_produto.Size = new System.Drawing.Size(155, 28);
            this.btnadd_produto.TabIndex = 19;
            this.btnadd_produto.Text = "Cadastrar Produtos";
            this.btnadd_produto.UseVisualStyleBackColor = true;
            this.btnadd_produto.Click += new System.EventHandler(this.btnadd_disc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, -16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pesquisar";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(497, 59);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(501, 31);
            this.txtpesquisa.TabIndex = 17;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // dtGridProdutos
            // 
            this.dtGridProdutos.AllowUserToAddRows = false;
            this.dtGridProdutos.AllowUserToDeleteRows = false;
            this.dtGridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdutos.Location = new System.Drawing.Point(33, 183);
            this.dtGridProdutos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtGridProdutos.Name = "dtGridProdutos";
            this.dtGridProdutos.ReadOnly = true;
            this.dtGridProdutos.RowHeadersWidth = 51;
            this.dtGridProdutos.Size = new System.Drawing.Size(985, 402);
            this.dtGridProdutos.TabIndex = 16;
            this.dtGridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProdutos_CellContentClick);
            this.dtGridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProdutos_CellDoubleClick);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ecommerce.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 601);
            this.Controls.Add(this.btnadd_produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.dtGridProdutos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProdutos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dtGridProdutos;
    }
}