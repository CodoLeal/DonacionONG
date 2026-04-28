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
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            donantesToolStripMenuItem = new ToolStripMenuItem();
            aportesToolStripMenuItem = new ToolStripMenuItem();
            proyectosToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            tablaDonantes = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDonantes).BeginInit();
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
            // panel6
            // 
            panel6.Location = new Point(233, 123);
            panel6.Name = "panel6";
            panel6.Size = new Size(1025, 104);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Location = new Point(15, 236);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 421);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(menuStrip1);
            panel4.Location = new Point(15, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 211);
            panel4.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(212, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { donantesToolStripMenuItem, aportesToolStripMenuItem, proyectosToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(59, 20);
            toolStripMenuItem1.Text = "Gestión";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // donantesToolStripMenuItem
            // 
            donantesToolStripMenuItem.Name = "donantesToolStripMenuItem";
            donantesToolStripMenuItem.Size = new Size(126, 22);
            donantesToolStripMenuItem.Text = "Donantes";
            donantesToolStripMenuItem.Click += donantesToolStripMenuItem_Click;
            // 
            // aportesToolStripMenuItem
            // 
            aportesToolStripMenuItem.Name = "aportesToolStripMenuItem";
            aportesToolStripMenuItem.Size = new Size(126, 22);
            aportesToolStripMenuItem.Text = "Aportes";
            // 
            // proyectosToolStripMenuItem
            // 
            proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            proyectosToolStripMenuItem.Size = new Size(126, 22);
            proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(233, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(1025, 104);
            panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(852, 23);
            textBox1.TabIndex = 0;
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
            tablaDonantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaDonantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            tablaDonantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDonantes.Dock = DockStyle.Fill;
            tablaDonantes.Location = new Point(0, 0);
            tablaDonantes.Name = "tablaDonantes";
            tablaDonantes.RowHeadersWidth = 51;
            tablaDonantes.Size = new Size(1025, 424);
            tablaDonantes.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 665);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaDonantes).EndInit();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem donantesToolStripMenuItem;
        private ToolStripMenuItem aportesToolStripMenuItem;
        private ToolStripMenuItem proyectosToolStripMenuItem;
    }
}