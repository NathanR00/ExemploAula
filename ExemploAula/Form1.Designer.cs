﻿namespace ExemploAula
{
    partial class Form1
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
            lbllogin = new Label();
            lblusuario = new Label();
            lblsenha = new Label();
            txtUsuario = new TextBox();
            txtsenha = new TextBox();
            btnlogar = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllogin.Location = new Point(341, 9);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(106, 47);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "Login";
            lbllogin.Click += label1_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 24F);
            lblusuario.Location = new Point(207, 101);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(128, 45);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuario";
            lblusuario.Click += lblusuario_Click;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI", 24F);
            lblsenha.Location = new Point(207, 170);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(106, 45);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.Font = new Font("Segoe UI", 15F);
            txtUsuario.Location = new Point(341, 111);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(188, 34);
            txtUsuario.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.BackColor = SystemColors.Window;
            txtsenha.Font = new Font("Segoe UI", 15F);
            txtsenha.Location = new Point(341, 181);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(188, 34);
            txtsenha.TabIndex = 4;
            // 
            // btnlogar
            // 
            btnlogar.Font = new Font("Segoe UI", 22F);
            btnlogar.Location = new Point(341, 251);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(139, 50);
            btnlogar.TabIndex = 5;
            btnlogar.Text = "Logar";
            btnlogar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogar);
            Controls.Add(txtsenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private Label lblsenha;
        private TextBox txtUsuario;
        private TextBox txtsenha;
        private Button btnlogar;
    }
}
