
namespace Ecommerce.Formularios
{
    partial class FrmVendasProdutos
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.cbDisciplinas = new System.Windows.Forms.ComboBox();
            this.Periodos = new System.Windows.Forms.Label();
            this.cbperiodos = new System.Windows.Forms.ComboBox();
            this.dtcursodisciplina = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Disciplinas = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtcursodisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pesquisar";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(22, 106);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(304, 20);
            this.txtpesquisa.TabIndex = 23;
            // 
            // cbDisciplinas
            // 
            this.cbDisciplinas.FormattingEnabled = true;
            this.cbDisciplinas.Items.AddRange(new object[] {
            "Programação web",
            "Banco de dados",
            "Analise e projeto de sistemas",
            "Design Digital",
            "Tecnicas de programação e algoritmo"});
            this.cbDisciplinas.Location = new System.Drawing.Point(22, 36);
            this.cbDisciplinas.Name = "cbDisciplinas";
            this.cbDisciplinas.Size = new System.Drawing.Size(121, 21);
            this.cbDisciplinas.TabIndex = 22;
            // 
            // Periodos
            // 
            this.Periodos.AutoSize = true;
            this.Periodos.Location = new System.Drawing.Point(349, 11);
            this.Periodos.Name = "Periodos";
            this.Periodos.Size = new System.Drawing.Size(74, 13);
            this.Periodos.TabIndex = 21;
            this.Periodos.Text = "Preço Unitário";
            // 
            // cbperiodos
            // 
            this.cbperiodos.FormattingEnabled = true;
            this.cbperiodos.Items.AddRange(new object[] {
            "1º ano",
            "2º ano",
            "3º ano"});
            this.cbperiodos.Location = new System.Drawing.Point(352, 36);
            this.cbperiodos.Name = "cbperiodos";
            this.cbperiodos.Size = new System.Drawing.Size(121, 21);
            this.cbperiodos.TabIndex = 20;
            // 
            // dtcursodisciplina
            // 
            this.dtcursodisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcursodisciplina.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtcursodisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcursodisciplina.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtcursodisciplina.Location = new System.Drawing.Point(22, 132);
            this.dtcursodisciplina.Name = "dtcursodisciplina";
            this.dtcursodisciplina.RowHeadersWidth = 51;
            this.dtcursodisciplina.Size = new System.Drawing.Size(739, 363);
            this.dtcursodisciplina.TabIndex = 19;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(666, 34);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Items.AddRange(new object[] {
            "Desenvolvimento de Sistemas(integrado)",
            "Desenvolvimento de Sistemas(noturno)"});
            this.cbxCursos.Location = new System.Drawing.Point(202, 36);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(121, 21);
            this.cbxCursos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ProdutoId";
            // 
            // Disciplinas
            // 
            this.Disciplinas.AutoSize = true;
            this.Disciplinas.Location = new System.Drawing.Point(20, 8);
            this.Disciplinas.Name = "Disciplinas";
            this.Disciplinas.Size = new System.Drawing.Size(47, 13);
            this.Disciplinas.TabIndex = 15;
            this.Disciplinas.Text = "VendaId";
            this.Disciplinas.Click += new System.EventHandler(this.Disciplinas_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(491, 8);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 25;
            this.Quantidade.Text = "Quantidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 26;
            // 
            // FrmVendasProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 505);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.cbDisciplinas);
            this.Controls.Add(this.Periodos);
            this.Controls.Add(this.cbperiodos);
            this.Controls.Add(this.dtcursodisciplina);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disciplinas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVendasProdutos";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dtcursodisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.ComboBox cbDisciplinas;
        private System.Windows.Forms.Label Periodos;
        private System.Windows.Forms.ComboBox cbperiodos;
        private System.Windows.Forms.DataGridView dtcursodisciplina;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Disciplinas;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.TextBox textBox1;
    }
}