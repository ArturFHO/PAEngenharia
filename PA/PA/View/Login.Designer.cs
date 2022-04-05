namespace PA.View
{
    partial class Login
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
            this.btn_login_entrar = new System.Windows.Forms.Button();
            this.btn_login_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_login_user = new System.Windows.Forms.TextBox();
            this.txb_login_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login_entrar
            // 
            this.btn_login_entrar.Location = new System.Drawing.Point(328, 18);
            this.btn_login_entrar.Name = "btn_login_entrar";
            this.btn_login_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_login_entrar.TabIndex = 0;
            this.btn_login_entrar.Text = "Entrar";
            this.btn_login_entrar.UseVisualStyleBackColor = true;
            this.btn_login_entrar.Click += new System.EventHandler(this.btn_login_entrar_Click);
            // 
            // btn_login_cancelar
            // 
            this.btn_login_cancelar.Location = new System.Drawing.Point(328, 59);
            this.btn_login_cancelar.Name = "btn_login_cancelar";
            this.btn_login_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_login_cancelar.TabIndex = 1;
            this.btn_login_cancelar.Text = "Cancelar";
            this.btn_login_cancelar.UseVisualStyleBackColor = true;
            this.btn_login_cancelar.Click += new System.EventHandler(this.btn_login_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // txb_login_user
            // 
            this.txb_login_user.Location = new System.Drawing.Point(84, 18);
            this.txb_login_user.Name = "txb_login_user";
            this.txb_login_user.Size = new System.Drawing.Size(226, 23);
            this.txb_login_user.TabIndex = 4;
            // 
            // txb_login_senha
            // 
            this.txb_login_senha.Location = new System.Drawing.Point(84, 59);
            this.txb_login_senha.Name = "txb_login_senha";
            this.txb_login_senha.PasswordChar = '*';
            this.txb_login_senha.Size = new System.Drawing.Size(226, 23);
            this.txb_login_senha.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 100);
            this.Controls.Add(this.txb_login_senha);
            this.Controls.Add(this.txb_login_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login_cancelar);
            this.Controls.Add(this.btn_login_entrar);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_login_entrar;
        private Button btn_login_cancelar;
        private Label label1;
        private Label label2;
        private TextBox txb_login_user;
        private TextBox txb_login_senha;
    }
}