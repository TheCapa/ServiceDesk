namespace Service_Desk
{
    partial class Esqueci_Senha
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblqualquercoisa = new System.Windows.Forms.Label();
            this.lblID_User = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtDigiteNovamente = new System.Windows.Forms.MaskedTextBox();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtGestor = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMudarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite Novamente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nova Senha";
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Location = new System.Drawing.Point(220, 174);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarSenha.TabIndex = 5;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(133, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(29, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Insira Uma Nova Senha ";
            // 
            // lblqualquercoisa
            // 
            this.lblqualquercoisa.AutoSize = true;
            this.lblqualquercoisa.Location = new System.Drawing.Point(224, 9);
            this.lblqualquercoisa.Name = "lblqualquercoisa";
            this.lblqualquercoisa.Size = new System.Drawing.Size(24, 13);
            this.lblqualquercoisa.TabIndex = 13;
            this.lblqualquercoisa.Text = "ID :";
            // 
            // lblID_User
            // 
            this.lblID_User.AutoSize = true;
            this.lblID_User.Location = new System.Drawing.Point(252, 9);
            this.lblID_User.Name = "lblID_User";
            this.lblID_User.Size = new System.Drawing.Size(43, 13);
            this.lblID_User.TabIndex = 14;
            this.lblID_User.Text = "ID.User";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(116, 52);
            this.txtNovaSenha.Mask = "999999";
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '●';
            this.txtNovaSenha.Size = new System.Drawing.Size(107, 20);
            this.txtNovaSenha.TabIndex = 16;
            // 
            // txtDigiteNovamente
            // 
            this.txtDigiteNovamente.Location = new System.Drawing.Point(116, 90);
            this.txtDigiteNovamente.Mask = "999999";
            this.txtDigiteNovamente.Name = "txtDigiteNovamente";
            this.txtDigiteNovamente.Size = new System.Drawing.Size(107, 20);
            this.txtDigiteNovamente.TabIndex = 17;
            this.txtDigiteNovamente.UseSystemPasswordChar = true;
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.Controls.Add(this.btnProximo);
            this.pnlMudarSenha.Controls.Add(this.txtNome);
            this.pnlMudarSenha.Controls.Add(this.txtFuncao);
            this.pnlMudarSenha.Controls.Add(this.txtGestor);
            this.pnlMudarSenha.Controls.Add(this.txtID);
            this.pnlMudarSenha.Controls.Add(this.label4);
            this.pnlMudarSenha.Controls.Add(this.label3);
            this.pnlMudarSenha.Controls.Add(this.label5);
            this.pnlMudarSenha.Controls.Add(this.label6);
            this.pnlMudarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMudarSenha.Location = new System.Drawing.Point(0, 0);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(316, 221);
            this.pnlMudarSenha.TabIndex = 18;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(223, 168);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 35;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click_2);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 34;
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(94, 137);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(100, 20);
            this.txtFuncao.TabIndex = 33;
            // 
            // txtGestor
            // 
            this.txtGestor.Location = new System.Drawing.Point(94, 100);
            this.txtGestor.Name = "txtGestor";
            this.txtGestor.Size = new System.Drawing.Size(100, 20);
            this.txtGestor.TabIndex = 32;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 64);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID Função";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gestor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID";
            // 
            // Esqueci_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 221);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.txtDigiteNovamente);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.lblID_User);
            this.Controls.Add(this.lblqualquercoisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterarSenha);
            this.Name = "Esqueci_Senha";
            this.Text = "Esqueci_Senha";
            this.Load += new System.EventHandler(this.Esqueci_Senha_Load);
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblqualquercoisa;
        private System.Windows.Forms.Label lblID_User;
        private System.Windows.Forms.MaskedTextBox txtNovaSenha;
        private System.Windows.Forms.MaskedTextBox txtDigiteNovamente;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.TextBox txtGestor;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}