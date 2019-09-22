namespace DestaoDeFrotaEntrada.PL
{
    partial class FormLoginCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginCliente));
            this.lblLoginSenhaCliente = new System.Windows.Forms.Label();
            this.lblLoginUsuarioCliente = new System.Windows.Forms.Label();
            this.txtLoginSenhaCliente = new System.Windows.Forms.TextBox();
            this.txtLoginUsuarioCliente = new System.Windows.Forms.TextBox();
            this.lblLoginCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btLoginCliente = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctLogin = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginSenhaCliente
            // 
            this.lblLoginSenhaCliente.AutoSize = true;
            this.lblLoginSenhaCliente.Location = new System.Drawing.Point(140, 222);
            this.lblLoginSenhaCliente.Name = "lblLoginSenhaCliente";
            this.lblLoginSenhaCliente.Size = new System.Drawing.Size(41, 13);
            this.lblLoginSenhaCliente.TabIndex = 9;
            this.lblLoginSenhaCliente.Text = "Senha:";
            // 
            // lblLoginUsuarioCliente
            // 
            this.lblLoginUsuarioCliente.AutoSize = true;
            this.lblLoginUsuarioCliente.Location = new System.Drawing.Point(140, 177);
            this.lblLoginUsuarioCliente.Name = "lblLoginUsuarioCliente";
            this.lblLoginUsuarioCliente.Size = new System.Drawing.Size(46, 13);
            this.lblLoginUsuarioCliente.TabIndex = 8;
            this.lblLoginUsuarioCliente.Text = "Usuário:";
            // 
            // txtLoginSenhaCliente
            // 
            this.txtLoginSenhaCliente.Location = new System.Drawing.Point(213, 215);
            this.txtLoginSenhaCliente.Name = "txtLoginSenhaCliente";
            this.txtLoginSenhaCliente.PasswordChar = '*';
            this.txtLoginSenhaCliente.Size = new System.Drawing.Size(100, 20);
            this.txtLoginSenhaCliente.TabIndex = 7;
            this.txtLoginSenhaCliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLoginUsuarioCliente
            // 
            this.txtLoginUsuarioCliente.Location = new System.Drawing.Point(213, 177);
            this.txtLoginUsuarioCliente.Name = "txtLoginUsuarioCliente";
            this.txtLoginUsuarioCliente.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsuarioCliente.TabIndex = 6;
            // 
            // lblLoginCliente
            // 
            this.lblLoginCliente.AutoSize = true;
            this.lblLoginCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginCliente.Location = new System.Drawing.Point(186, 100);
            this.lblLoginCliente.Name = "lblLoginCliente";
            this.lblLoginCliente.Size = new System.Drawing.Size(86, 25);
            this.lblLoginCliente.TabIndex = 5;
            this.lblLoginCliente.Text = "Cliente";
            this.lblLoginCliente.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login";
            // 
            // btLoginCliente
            // 
            this.btLoginCliente.Location = new System.Drawing.Point(197, 293);
            this.btLoginCliente.Name = "btLoginCliente";
            this.btLoginCliente.Size = new System.Drawing.Size(75, 23);
            this.btLoginCliente.TabIndex = 12;
            this.btLoginCliente.Text = "Entrar";
            this.btLoginCliente.UseVisualStyleBackColor = true;
            this.btLoginCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.conectarToolStripMenuItem.Text = "Página inicial";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDoUsuárioToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // manualDoUsuárioToolStripMenuItem
            // 
            this.manualDoUsuárioToolStripMenuItem.Name = "manualDoUsuárioToolStripMenuItem";
            this.manualDoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.manualDoUsuárioToolStripMenuItem.Text = "Manual do Usuário";
            // 
            // pctLogin
            // 
            this.pctLogin.Image = ((System.Drawing.Image)(resources.GetObject("pctLogin.Image")));
            this.pctLogin.Location = new System.Drawing.Point(33, 155);
            this.pctLogin.Name = "pctLogin";
            this.pctLogin.Size = new System.Drawing.Size(101, 106);
            this.pctLogin.TabIndex = 20;
            this.pctLogin.TabStop = false;
            // 
            // FormLoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 378);
            this.Controls.Add(this.pctLogin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btLoginCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLoginSenhaCliente);
            this.Controls.Add(this.lblLoginUsuarioCliente);
            this.Controls.Add(this.txtLoginSenhaCliente);
            this.Controls.Add(this.txtLoginUsuarioCliente);
            this.Controls.Add(this.lblLoginCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoginCliente";
            this.Text = "Gestao De Frotas";
            this.Load += new System.EventHandler(this.FormLoginCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoginSenhaCliente;
        private System.Windows.Forms.Label lblLoginUsuarioCliente;
        private System.Windows.Forms.TextBox txtLoginSenhaCliente;
        private System.Windows.Forms.TextBox txtLoginUsuarioCliente;
        private System.Windows.Forms.Label lblLoginCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLoginCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctLogin;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

