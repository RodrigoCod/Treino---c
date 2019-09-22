namespace DestaoDeFrotaEntrada.PL
{
    partial class FormLoginEmpregado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginEmpregado));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btLoginFuncionario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLoginSenhaFuncionario = new System.Windows.Forms.Label();
            this.lblLoginUsuarioFuncionario = new System.Windows.Forms.Label();
            this.txtLoginSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.txtLoginUsuarioFuncionario = new System.Windows.Forms.TextBox();
            this.pctLogin = new System.Windows.Forms.PictureBox();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 18;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Funcionario";
            // 
            // btLoginFuncionario
            // 
            this.btLoginFuncionario.Location = new System.Drawing.Point(205, 304);
            this.btLoginFuncionario.Name = "btLoginFuncionario";
            this.btLoginFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btLoginFuncionario.TabIndex = 27;
            this.btLoginFuncionario.Text = "Entrar";
            this.btLoginFuncionario.UseVisualStyleBackColor = true;
            this.btLoginFuncionario.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Login";
            // 
            // lblLoginSenhaFuncionario
            // 
            this.lblLoginSenhaFuncionario.AutoSize = true;
            this.lblLoginSenhaFuncionario.Location = new System.Drawing.Point(148, 233);
            this.lblLoginSenhaFuncionario.Name = "lblLoginSenhaFuncionario";
            this.lblLoginSenhaFuncionario.Size = new System.Drawing.Size(41, 13);
            this.lblLoginSenhaFuncionario.TabIndex = 25;
            this.lblLoginSenhaFuncionario.Text = "Senha:";
            // 
            // lblLoginUsuarioFuncionario
            // 
            this.lblLoginUsuarioFuncionario.AutoSize = true;
            this.lblLoginUsuarioFuncionario.Location = new System.Drawing.Point(148, 188);
            this.lblLoginUsuarioFuncionario.Name = "lblLoginUsuarioFuncionario";
            this.lblLoginUsuarioFuncionario.Size = new System.Drawing.Size(46, 13);
            this.lblLoginUsuarioFuncionario.TabIndex = 24;
            this.lblLoginUsuarioFuncionario.Text = "Usuário:";
            // 
            // txtLoginSenhaFuncionario
            // 
            this.txtLoginSenhaFuncionario.Location = new System.Drawing.Point(221, 226);
            this.txtLoginSenhaFuncionario.Name = "txtLoginSenhaFuncionario";
            this.txtLoginSenhaFuncionario.PasswordChar = '*';
            this.txtLoginSenhaFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtLoginSenhaFuncionario.TabIndex = 23;
            // 
            // txtLoginUsuarioFuncionario
            // 
            this.txtLoginUsuarioFuncionario.Location = new System.Drawing.Point(221, 188);
            this.txtLoginUsuarioFuncionario.Name = "txtLoginUsuarioFuncionario";
            this.txtLoginUsuarioFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsuarioFuncionario.TabIndex = 22;
            // 
            // pctLogin
            // 
            this.pctLogin.Image = ((System.Drawing.Image)(resources.GetObject("pctLogin.Image")));
            this.pctLogin.Location = new System.Drawing.Point(29, 167);
            this.pctLogin.Name = "pctLogin";
            this.pctLogin.Size = new System.Drawing.Size(101, 106);
            this.pctLogin.TabIndex = 28;
            this.pctLogin.TabStop = false;
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormLoginEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 386);
            this.Controls.Add(this.pctLogin);
            this.Controls.Add(this.btLoginFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLoginSenhaFuncionario);
            this.Controls.Add(this.lblLoginUsuarioFuncionario);
            this.Controls.Add(this.txtLoginSenhaFuncionario);
            this.Controls.Add(this.txtLoginUsuarioFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoginEmpregado";
            this.Text = "Gestao De Frotas";
            this.Load += new System.EventHandler(this.FormLoginFuncinario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLoginFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLoginSenhaFuncionario;
        private System.Windows.Forms.Label lblLoginUsuarioFuncionario;
        private System.Windows.Forms.TextBox txtLoginSenhaFuncionario;
        private System.Windows.Forms.TextBox txtLoginUsuarioFuncionario;
        private System.Windows.Forms.PictureBox pctLogin;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}