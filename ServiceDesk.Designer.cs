namespace Service_Desk
{
    partial class ServiceDeskGerenciador
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbAberturaChamado = new System.Windows.Forms.TabPage();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbAcompanhamento = new System.Windows.Forms.TabPage();
            this.tbRastreio = new System.Windows.Forms.TabPage();
            this.tbRelatorio = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.lblLogadoComo = new System.Windows.Forms.Label();
            this.lblUser_Logado = new System.Windows.Forms.Label();
            this.tbControl.SuspendLayout();
            this.tbAberturaChamado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbAberturaChamado);
            this.tbControl.Controls.Add(this.tbAcompanhamento);
            this.tbControl.Controls.Add(this.tbRastreio);
            this.tbControl.Controls.Add(this.tbRelatorio);
            this.tbControl.Location = new System.Drawing.Point(12, 43);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(768, 468);
            this.tbControl.TabIndex = 0;
            // 
            // tbAberturaChamado
            // 
            this.tbAberturaChamado.Controls.Add(this.btnEnviar);
            this.tbAberturaChamado.Location = new System.Drawing.Point(4, 26);
            this.tbAberturaChamado.Name = "tbAberturaChamado";
            this.tbAberturaChamado.Padding = new System.Windows.Forms.Padding(3);
            this.tbAberturaChamado.Size = new System.Drawing.Size(760, 438);
            this.tbAberturaChamado.TabIndex = 1;
            this.tbAberturaChamado.Text = "Abertura de Chamado";
            this.tbAberturaChamado.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(334, 267);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 30);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tbAcompanhamento
            // 
            this.tbAcompanhamento.Location = new System.Drawing.Point(4, 26);
            this.tbAcompanhamento.Name = "tbAcompanhamento";
            this.tbAcompanhamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbAcompanhamento.Size = new System.Drawing.Size(760, 438);
            this.tbAcompanhamento.TabIndex = 2;
            this.tbAcompanhamento.Text = "Acompanhamento";
            this.tbAcompanhamento.UseVisualStyleBackColor = true;
            // 
            // tbRastreio
            // 
            this.tbRastreio.Location = new System.Drawing.Point(4, 26);
            this.tbRastreio.Name = "tbRastreio";
            this.tbRastreio.Padding = new System.Windows.Forms.Padding(3);
            this.tbRastreio.Size = new System.Drawing.Size(760, 438);
            this.tbRastreio.TabIndex = 3;
            this.tbRastreio.Text = "Rastreio";
            this.tbRastreio.UseVisualStyleBackColor = true;
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.Location = new System.Drawing.Point(4, 26);
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tbRelatorio.Size = new System.Drawing.Size(760, 438);
            this.tbRelatorio.TabIndex = 4;
            this.tbRelatorio.Text = "Relatório";
            this.tbRelatorio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 25);
            this.textBox1.TabIndex = 0;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(308, 15);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(66, 17);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(627, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.Location = new System.Drawing.Point(705, 13);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(75, 24);
            this.btnDeslogar.TabIndex = 3;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // lblLogadoComo
            // 
            this.lblLogadoComo.AutoSize = true;
            this.lblLogadoComo.Location = new System.Drawing.Point(9, 15);
            this.lblLogadoComo.Name = "lblLogadoComo";
            this.lblLogadoComo.Size = new System.Drawing.Size(96, 17);
            this.lblLogadoComo.TabIndex = 4;
            this.lblLogadoComo.Text = "Logado Como:";
            this.lblLogadoComo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUser_Logado
            // 
            this.lblUser_Logado.AutoSize = true;
            this.lblUser_Logado.Location = new System.Drawing.Point(111, 16);
            this.lblUser_Logado.Name = "lblUser_Logado";
            this.lblUser_Logado.Size = new System.Drawing.Size(35, 17);
            this.lblUser_Logado.TabIndex = 5;
            this.lblUser_Logado.Text = "User";
            // 
            // ServiceDeskGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.lblUser_Logado);
            this.Controls.Add(this.lblLogadoComo);
            this.Controls.Add(this.btnDeslogar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceDeskGerenciador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Desk - Gerenciador";
            this.Load += new System.EventHandler(this.ServiceDeskGerenciador_Load);
            this.tbControl.ResumeLayout(false);
            this.tbAberturaChamado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbAberturaChamado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tbAcompanhamento;
        private System.Windows.Forms.TabPage tbRastreio;
        private System.Windows.Forms.TabPage tbRelatorio;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.Label lblLogadoComo;
        private System.Windows.Forms.Label lblUser_Logado;
    }
}