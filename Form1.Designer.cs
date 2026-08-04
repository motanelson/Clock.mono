namespace ClockGui
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbrushexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.pbrushexeToolStripMenuItem,
            this.calcexeToolStripMenuItem,
            this.explorerexeToolStripMenuItem,
            this.edgeToolStripMenuItem,
            this.mailToolStripMenuItem,
            this.cmdToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 24);
            this.toolStripMenuItem1.Text = "progman";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem.Text = "notepad.exe";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem1.Text = "exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // pbrushexeToolStripMenuItem
            // 
            this.pbrushexeToolStripMenuItem.Name = "pbrushexeToolStripMenuItem";
            this.pbrushexeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pbrushexeToolStripMenuItem.Text = "pbrush.exe";
            this.pbrushexeToolStripMenuItem.Click += new System.EventHandler(this.pbrushexeToolStripMenuItem_Click);
            // 
            // calcexeToolStripMenuItem
            // 
            this.calcexeToolStripMenuItem.Name = "calcexeToolStripMenuItem";
            this.calcexeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calcexeToolStripMenuItem.Text = "calc.exe";
            this.calcexeToolStripMenuItem.Click += new System.EventHandler(this.calcexeToolStripMenuItem_Click);
            // 
            // explorerexeToolStripMenuItem
            // 
            this.explorerexeToolStripMenuItem.Name = "explorerexeToolStripMenuItem";
            this.explorerexeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.explorerexeToolStripMenuItem.Text = "explorer.exe";
            this.explorerexeToolStripMenuItem.Click += new System.EventHandler(this.explorerexeToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.edgeToolStripMenuItem.Text = "edge";
            this.edgeToolStripMenuItem.Click += new System.EventHandler(this.edgeToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mailToolStripMenuItem.Text = "mail";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // cmdToolStripMenuItem
            // 
            this.cmdToolStripMenuItem.Name = "cmdToolStripMenuItem";
            this.cmdToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cmdToolStripMenuItem.Text = "cmd";
            this.cmdToolStripMenuItem.Click += new System.EventHandler(this.cmdToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 236);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "clock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pbrushexeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcexeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerexeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

