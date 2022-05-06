namespace PA.View
{
    partial class CargoView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmr_sal_cargo = new System.Windows.Forms.NumericUpDown();
            this.nmr_nivel_cargo = new System.Windows.Forms.NumericUpDown();
            this.txb_id_cargo = new System.Windows.Forms.TextBox();
            this.txb_desc_cargo = new System.Windows.Forms.TextBox();
            this.btn_cargo_pesquisar = new System.Windows.Forms.Button();
            this.btn_cargo_incluir = new System.Windows.Forms.Button();
            this.btn_cargo_excluir = new System.Windows.Forms.Button();
            this.btn_cargo_alterar = new System.Windows.Forms.Button();
            this.btn_cargo_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_sal_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_nivel_cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nível:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salário:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição do Cargo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nmr_sal_cargo
            // 
            this.nmr_sal_cargo.Location = new System.Drawing.Point(78, 68);
            this.nmr_sal_cargo.Name = "nmr_sal_cargo";
            this.nmr_sal_cargo.Size = new System.Drawing.Size(120, 23);
            this.nmr_sal_cargo.TabIndex = 6;
            // 
            // nmr_nivel_cargo
            // 
            this.nmr_nivel_cargo.Location = new System.Drawing.Point(70, 97);
            this.nmr_nivel_cargo.Name = "nmr_nivel_cargo";
            this.nmr_nivel_cargo.Size = new System.Drawing.Size(70, 23);
            this.nmr_nivel_cargo.TabIndex = 7;
            // 
            // txb_id_cargo
            // 
            this.txb_id_cargo.Location = new System.Drawing.Point(54, 10);
            this.txb_id_cargo.Name = "txb_id_cargo";
            this.txb_id_cargo.Size = new System.Drawing.Size(100, 23);
            this.txb_id_cargo.TabIndex = 8;
            // 
            // txb_desc_cargo
            // 
            this.txb_desc_cargo.Location = new System.Drawing.Point(146, 39);
            this.txb_desc_cargo.Name = "txb_desc_cargo";
            this.txb_desc_cargo.Size = new System.Drawing.Size(253, 23);
            this.txb_desc_cargo.TabIndex = 9;
            // 
            // btn_cargo_pesquisar
            // 
            this.btn_cargo_pesquisar.Location = new System.Drawing.Point(181, 10);
            this.btn_cargo_pesquisar.Name = "btn_cargo_pesquisar";
            this.btn_cargo_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargo_pesquisar.TabIndex = 10;
            this.btn_cargo_pesquisar.Text = "Pesquisar";
            this.btn_cargo_pesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_cargo_incluir
            // 
            this.btn_cargo_incluir.Location = new System.Drawing.Point(27, 144);
            this.btn_cargo_incluir.Name = "btn_cargo_incluir";
            this.btn_cargo_incluir.Size = new System.Drawing.Size(93, 40);
            this.btn_cargo_incluir.TabIndex = 14;
            this.btn_cargo_incluir.Text = "Incluir";
            this.btn_cargo_incluir.UseVisualStyleBackColor = true;
            // 
            // btn_cargo_excluir
            // 
            this.btn_cargo_excluir.Location = new System.Drawing.Point(225, 144);
            this.btn_cargo_excluir.Name = "btn_cargo_excluir";
            this.btn_cargo_excluir.Size = new System.Drawing.Size(93, 40);
            this.btn_cargo_excluir.TabIndex = 15;
            this.btn_cargo_excluir.Text = "Excluir";
            this.btn_cargo_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cargo_alterar
            // 
            this.btn_cargo_alterar.Location = new System.Drawing.Point(126, 144);
            this.btn_cargo_alterar.Name = "btn_cargo_alterar";
            this.btn_cargo_alterar.Size = new System.Drawing.Size(93, 40);
            this.btn_cargo_alterar.TabIndex = 16;
            this.btn_cargo_alterar.Text = "Alterar";
            this.btn_cargo_alterar.UseVisualStyleBackColor = true;
            this.btn_cargo_alterar.Click += new System.EventHandler(this.btn_cargo_alterar_Click);
            // 
            // btn_cargo_fechar
            // 
            this.btn_cargo_fechar.Location = new System.Drawing.Point(356, 161);
            this.btn_cargo_fechar.Name = "btn_cargo_fechar";
            this.btn_cargo_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargo_fechar.TabIndex = 17;
            this.btn_cargo_fechar.Text = "Fechar";
            this.btn_cargo_fechar.UseVisualStyleBackColor = true;
            // 
            // CargoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 215);
            this.Controls.Add(this.btn_cargo_fechar);
            this.Controls.Add(this.btn_cargo_alterar);
            this.Controls.Add(this.btn_cargo_excluir);
            this.Controls.Add(this.btn_cargo_incluir);
            this.Controls.Add(this.btn_cargo_pesquisar);
            this.Controls.Add(this.txb_desc_cargo);
            this.Controls.Add(this.txb_id_cargo);
            this.Controls.Add(this.nmr_nivel_cargo);
            this.Controls.Add(this.nmr_sal_cargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CargoView";
            this.Text = "CargoView";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_sal_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_nivel_cargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nmr_sal_cargo;
        private NumericUpDown nmr_nivel_cargo;
        private TextBox txb_id_cargo;
        private TextBox txb_desc_cargo;
        private Button btn_cargo_pesquisar;
        private Button btn_cargo_incluir;
        private Button btn_cargo_excluir;
        private Button btn_cargo_alterar;
        private Button btn_cargo_fechar;
    }
}