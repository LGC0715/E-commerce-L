
namespace Ecommerce.Formularios
{
    partial class FrmVendas
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
            this.btnadd_venda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dtGridVenda = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd_venda
            // 
            this.btnadd_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd_venda.Location = new System.Drawing.Point(636, 103);
            this.btnadd_venda.Name = "btnadd_venda";
            this.btnadd_venda.Size = new System.Drawing.Size(115, 23);
            this.btnadd_venda.TabIndex = 19;
            this.btnadd_venda.Text = "Cadastrar Venda";
            this.btnadd_venda.UseVisualStyleBackColor = true;
            this.btnadd_venda.Click += new System.EventHandler(this.btnadd_venda_Click);
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
            this.txtpesquisa.BackColor = System.Drawing.Color.White;
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(371, 54);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(380, 24);
            this.txtpesquisa.TabIndex = 17;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged_1);
            // 
            // dtGridVenda
            // 
            this.dtGridVenda.AllowUserToAddRows = false;
            this.dtGridVenda.AllowUserToDeleteRows = false;
            this.dtGridVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridVenda.BackgroundColor = System.Drawing.Color.White;
            this.dtGridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVenda.GridColor = System.Drawing.Color.White;
            this.dtGridVenda.Location = new System.Drawing.Point(38, 151);
            this.dtGridVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtGridVenda.Name = "dtGridVenda";
            this.dtGridVenda.ReadOnly = true;
            this.dtGridVenda.RowHeadersWidth = 51;
            this.dtGridVenda.Size = new System.Drawing.Size(731, 321);
            this.dtGridVenda.TabIndex = 16;
            this.dtGridVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridVenda_CellDoubleClick);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(404, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 69;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ecommerce.Properties.Resources._21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnadd_venda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.dtGridVenda);
            this.DoubleBuffered = true;
            this.Name = "FrmVendas";
            this.Text = "FormVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dtGridVenda;
        private System.Windows.Forms.Label txtId;
    }
}