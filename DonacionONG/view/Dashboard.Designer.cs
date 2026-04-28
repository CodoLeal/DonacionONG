namespace DonacionONG.view
{
    partial class Dashboard
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
            panel1 = new Panel();
            panel2 = new Panel();
            tablaDonantes = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDonantes).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 668);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDonantes);
            panel2.Location = new Point(233, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 424);
            panel2.TabIndex = 0;
            // 
            // tablaDonantes
            // 
            tablaDonantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDonantes.Location = new Point(0, 3);
            tablaDonantes.Name = "tablaDonantes";
            tablaDonantes.Size = new Size(1022, 421);
            tablaDonantes.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(233, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(1025, 104);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(15, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 211);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Location = new Point(15, 236);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 421);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Location = new Point(233, 123);
            panel6.Name = "panel6";
            panel6.Size = new Size(1025, 104);
            panel6.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(852, 23);
            textBox1.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 665);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaDonantes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView tablaDonantes;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private TextBox textBox1;
    }
}