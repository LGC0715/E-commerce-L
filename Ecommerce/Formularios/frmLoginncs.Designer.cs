namespace Ecommerce.Formularios
{
    partial class frmLoginncs
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
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(61, 288);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(158, 33);
            this.btn_Entrar.TabIndex = 51;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(58, 235);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(58, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 49;
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(52, 207);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(81, 25);
            this.txtSenha.TabIndex = 48;
            this.txtSenha.Text = "SENHA";
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(52, 117);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(73, 25);
            this.txtLogin.TabIndex = 47;
            this.txtLogin.Text = "LOGIN";
            // 
            // frmLoginncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmLoginncs";
            this.Text = "frmLoginncs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Label txtLogin;
    }
}