
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
            ((System.ComponentModel.ISupportInitialize)(this.dtcursodisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pesquisar";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(30, 130);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(404, 22);
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
            this.cbDisciplinas.Location = new System.Drawing.Point(30, 44);
            this.cbDisciplinas.Margin = new System.Windows.Forms.Padding(4);
            this.cbDisciplinas.Name = "cbDisciplinas";
            this.cbDisciplinas.Size = new System.Drawing.Size(160, 24);
            this.cbDisciplinas.TabIndex = 22;
            // 
            // Periodos
            // 
            this.Periodos.AutoSize = true;
            this.Periodos.Location = new System.Drawing.Point(509, 13);
            this.Periodos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Periodos.Name = "Periodos";
            this.Periodos.Size = new System.Drawing.Size(62, 16);
            this.Periodos.TabIndex = 21;
            this.Periodos.Text = "Periodos";
            // 
            // cbperiodos
            // 
            this.cbperiodos.FormattingEnabled = true;
            this.cbperiodos.Items.AddRange(new object[] {
            "1º ano",
            "2º ano",
            "3º ano"});
            this.cbperiodos.Location = new System.Drawing.Point(513, 44);
            this.cbperiodos.Margin = new System.Windows.Forms.Padding(4);
            this.cbperiodos.Name = "cbperiodos";
            this.cbperiodos.Size = new System.Drawing.Size(160, 24);
            this.cbperiodos.TabIndex = 20;
            // 
            // dtcursodisciplina
            // 
            this.dtcursodisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcursodisciplina.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtcursodisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcursodisciplina.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtcursodisciplina.Location = new System.Drawing.Point(30, 162);
            this.dtcursodisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.dtcursodisciplina.Name = "dtcursodisciplina";
            this.dtcursodisciplina.RowHeadersWidth = 51;
            this.dtcursodisciplina.Size = new System.Drawing.Size(985, 447);
            this.dtcursodisciplina.TabIndex = 19;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(758, 44);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 28);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Items.AddRange(new object[] {
            "Desenvolvimento de Sistemas(integrado)",
            "Desenvolvimento de Sistemas(noturno)"});
            this.cbxCursos.Location = new System.Drawing.Point(269, 44);
            this.cbxCursos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(160, 24);
            this.cbxCursos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Curso";
            // 
            // Disciplinas
            // 
            this.Disciplinas.AutoSize = true;
            this.Disciplinas.Location = new System.Drawing.Point(26, 10);
            this.Disciplinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Disciplinas.Name = "Disciplinas";
            this.Disciplinas.Size = new System.Drawing.Size(73, 16);
            this.Disciplinas.TabIndex = 15;
            this.Disciplinas.Text = "Disciplinas";
            // 
            // FrmVendasProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 622);
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
    }
}