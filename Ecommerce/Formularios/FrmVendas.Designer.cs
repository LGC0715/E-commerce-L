﻿
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
            this.btnadd_venda.Location = new System.Drawing.Point(796, 127);
            this.btnadd_venda.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd_venda.Name = "btnadd_venda";
            this.btnadd_venda.Size = new System.Drawing.Size(153, 28);
            this.btnadd_venda.TabIndex = 19;
            this.btnadd_venda.Text = "Cadastrar Venda";
            this.btnadd_venda.UseVisualStyleBackColor = true;
            this.btnadd_venda.Click += new System.EventHandler(this.btnadd_venda_Click);
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
            this.txtpesquisa.BackColor = System.Drawing.Color.White;
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(459, 64);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(505, 29);
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
            this.dtGridVenda.Location = new System.Drawing.Point(51, 186);
            this.dtGridVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtGridVenda.Name = "dtGridVenda";
            this.dtGridVenda.ReadOnly = true;
            this.dtGridVenda.RowHeadersWidth = 51;
            this.dtGridVenda.Size = new System.Drawing.Size(938, 395);
            this.dtGridVenda.TabIndex = 16;
            this.dtGridVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridVenda_CellDoubleClick);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(539, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 16);
            this.txtId.TabIndex = 69;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Ecommerce.Properties.Resources._21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 596);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnadd_venda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.dtGridVenda);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVendas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDAS";
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