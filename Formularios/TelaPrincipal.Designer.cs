namespace ClinicaVeterinariaForms
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBoxLogin = new GroupBox();
            linkLblCadastrar = new LinkLabel();
            btnEntrar = new Button();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblTitulo = new Label();
            gBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxLogin
            // 
            gBoxLogin.BackColor = Color.Transparent;
            gBoxLogin.Controls.Add(linkLblCadastrar);
            gBoxLogin.Controls.Add(btnEntrar);
            gBoxLogin.Controls.Add(lblSenha);
            gBoxLogin.Controls.Add(txtSenha);
            gBoxLogin.Controls.Add(lblUsuario);
            gBoxLogin.Controls.Add(txtUsuario);
            gBoxLogin.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gBoxLogin.ForeColor = Color.White;
            gBoxLogin.Location = new Point(35, 157);
            gBoxLogin.Name = "gBoxLogin";
            gBoxLogin.Size = new Size(341, 221);
            gBoxLogin.TabIndex = 0;
            gBoxLogin.TabStop = false;
            gBoxLogin.Text = "Login";
            // 
            // linkLblCadastrar
            // 
            linkLblCadastrar.AutoSize = true;
            linkLblCadastrar.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLblCadastrar.LinkColor = Color.Black;
            linkLblCadastrar.Location = new Point(39, 175);
            linkLblCadastrar.Name = "linkLblCadastrar";
            linkLblCadastrar.Size = new Size(89, 17);
            linkLblCadastrar.TabIndex = 6;
            linkLblCadastrar.TabStop = true;
            linkLblCadastrar.Text = "Cadastrar";
            linkLblCadastrar.LinkClicked += linkLblCadastrar_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(255, 128, 0);
            btnEntrar.Location = new Point(193, 172);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(39, 102);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(47, 16);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(39, 121);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(216, 22);
            txtSenha.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(39, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 16);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(39, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(216, 22);
            txtUsuario.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Courier New", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(35, 63);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(282, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clínica Vet+";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 253, 245);
            BackgroundImage = Properties.Resources.tela_inicial;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(gBoxLogin);
            Name = "TelaPrincipal";
            Text = "Clínica Vet+";
            gBoxLogin.ResumeLayout(false);
            gBoxLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxLogin;
        private Label lblTitulo;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label lblSenha;
        private LinkLabel linkLblCadastrar;
    }
}
