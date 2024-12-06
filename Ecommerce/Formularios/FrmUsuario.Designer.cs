
namespace Ecommerce.Formularios
{
    partial class frmUsuarios
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
            this.dtgridUsuarios1 = new System.Windows.Forms.DataGridView();
            this.txtPesquisar1 = new System.Windows.Forms.TextBox();
            this.btnNovo1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUsuarios1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridUsuarios1
            // 
            this.dtgridUsuarios1.AllowUserToAddRows = false;
            this.dtgridUsuarios1.AllowUserToDeleteRows = false;
            this.dtgridUsuarios1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridUsuarios1.BackgroundColor = System.Drawing.Color.White;
            this.dtgridUsuarios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridUsuarios1.GridColor = System.Drawing.Color.White;
            this.dtgridUsuarios1.Location = new System.Drawing.Point(34, 153);
            this.dtgridUsuarios1.Name = "dtgridUsuarios1";
            this.dtgridUsuarios1.ReadOnly = true;
            this.dtgridUsuarios1.RowHeadersWidth = 51;
            this.dtgridUsuarios1.Size = new System.Drawing.Size(712, 318);
            this.dtgridUsuarios1.TabIndex = 5;
            this.dtgridUsuarios1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridUsuarios1_CellContentClick);
            this.dtgridUsuarios1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridUsuarios1_CellDoubleClick_1);
            // 
            // txtPesquisar1
            // 
            this.txtPesquisar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar1.Location = new System.Drawing.Point(361, 99);
            this.txtPesquisar1.Name = "txtPesquisar1";
            this.txtPesquisar1.Size = new System.Drawing.Size(376, 24);
            this.txtPesquisar1.TabIndex = 1;
            this.txtPesquisar1.TextChanged += new System.EventHandler(this.txtPesquisar1_TextChanged);
            // 
            // btnNovo1
            // 
            this.btnNovo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo1.Location = new System.Drawing.Point(48, 100);
            this.btnNovo1.Name = "btnNovo1";
            this.btnNovo1.Size = new System.Drawing.Size(107, 23);
            this.btnNovo1.TabIndex = 0;
            this.btnNovo1.Text = "Novo Usuário";
            this.btnNovo1.UseVisualStyleBackColor = true;
            this.btnNovo1.Click += new System.EventHandler(this.btnNovo1_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ecommerce.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 483);
            this.Controls.Add(this.dtgridUsuarios1);
            this.Controls.Add(this.btnNovo1);
            this.Controls.Add(this.txtPesquisar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registre um usuário";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUsuarios1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridUsuarios1;
        private System.Windows.Forms.TextBox txtPesquisar1;
        private System.Windows.Forms.Button btnNovo1;
    }
}