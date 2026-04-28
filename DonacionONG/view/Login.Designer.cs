namespace DonacionONG
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            lblTitulo = new Label();
            label1 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPass = new TextBox();
            txtUsername = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 730);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 709);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblTitulo);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(349, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 710);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(24, 157);
            label4.Name = "label4";
            label4.Size = new Size(535, 63);
            label4.TabIndex = 7;
            label4.Text = "Inicia sesión para continuar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Lucida Bright", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(24, 96);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(535, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido a";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Lucida Bright", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(24, 122);
            label1.Name = "label1";
            label1.Size = new Size(535, 45);
            label1.TabIndex = 6;
            label1.Text = "DonaVida";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 0, 192);
            btnLogin.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(88, 413);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(414, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(24, 247);
            label2.Name = "label2";
            label2.Size = new Size(535, 22);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(24, 312);
            label3.Name = "label3";
            label3.Size = new Size(535, 22);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(24, 337);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(535, 23);
            txtPass.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.ForeColor = SystemColors.InactiveCaptionText;
            txtUsername.Location = new Point(24, 272);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(535, 23);
            txtUsername.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 712);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitulo;
        private TextBox txtUsername;
        private TextBox txtPass;
        private Label label3;
        private Label label2;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
    }
}
