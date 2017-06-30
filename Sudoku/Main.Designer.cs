namespace Sudoku
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оченьЛегкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оченьСложноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.подсказкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.победитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgpanel = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.bgpanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПолеToolStripMenuItem,
            this.очиститьПолеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.подсказкаToolStripMenuItem,
            this.победитьToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // создатьПолеToolStripMenuItem
            // 
            this.создатьПолеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оченьЛегкоToolStripMenuItem,
            this.легкоToolStripMenuItem,
            this.сToolStripMenuItem,
            this.сложноToolStripMenuItem,
            this.оченьСложноToolStripMenuItem});
            this.создатьПолеToolStripMenuItem.Name = "создатьПолеToolStripMenuItem";
            this.создатьПолеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.создатьПолеToolStripMenuItem.Text = "Новая игра";
            // 
            // оченьЛегкоToolStripMenuItem
            // 
            this.оченьЛегкоToolStripMenuItem.Name = "оченьЛегкоToolStripMenuItem";
            this.оченьЛегкоToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.оченьЛегкоToolStripMenuItem.Text = "Очень легко";
            this.оченьЛегкоToolStripMenuItem.Click += new System.EventHandler(this.оченьЛегкоToolStripMenuItem_Click);
            // 
            // легкоToolStripMenuItem
            // 
            this.легкоToolStripMenuItem.Name = "легкоToolStripMenuItem";
            this.легкоToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.легкоToolStripMenuItem.Text = "Легко";
            this.легкоToolStripMenuItem.Click += new System.EventHandler(this.легкоToolStripMenuItem_Click);
            // 
            // сToolStripMenuItem
            // 
            this.сToolStripMenuItem.Name = "сToolStripMenuItem";
            this.сToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.сToolStripMenuItem.Text = "Средне";
            this.сToolStripMenuItem.Click += new System.EventHandler(this.сToolStripMenuItem_Click);
            // 
            // сложноToolStripMenuItem
            // 
            this.сложноToolStripMenuItem.Name = "сложноToolStripMenuItem";
            this.сложноToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.сложноToolStripMenuItem.Text = "Сложно";
            this.сложноToolStripMenuItem.Click += new System.EventHandler(this.сложноToolStripMenuItem_Click);
            // 
            // оченьСложноToolStripMenuItem
            // 
            this.оченьСложноToolStripMenuItem.Name = "оченьСложноToolStripMenuItem";
            this.оченьСложноToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.оченьСложноToolStripMenuItem.Text = "Очень сложно";
            this.оченьСложноToolStripMenuItem.Click += new System.EventHandler(this.оченьСложноToolStripMenuItem_Click);
            // 
            // очиститьПолеToolStripMenuItem
            // 
            this.очиститьПолеToolStripMenuItem.Name = "очиститьПолеToolStripMenuItem";
            this.очиститьПолеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.очиститьПолеToolStripMenuItem.Text = "Очистить поле";
            this.очиститьПолеToolStripMenuItem.Click += new System.EventHandler(this.очиститьПолеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // подсказкаToolStripMenuItem
            // 
            this.подсказкаToolStripMenuItem.CheckOnClick = true;
            this.подсказкаToolStripMenuItem.Name = "подсказкаToolStripMenuItem";
            this.подсказкаToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.подсказкаToolStripMenuItem.Text = "Подсказка";
            this.подсказкаToolStripMenuItem.Click += new System.EventHandler(this.подсказкаToolStripMenuItem_Click);
            // 
            // победитьToolStripMenuItem
            // 
            this.победитьToolStripMenuItem.Name = "победитьToolStripMenuItem";
            this.победитьToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.победитьToolStripMenuItem.Text = "Победить";
            this.победитьToolStripMenuItem.Click += new System.EventHandler(this.победитьToolStripMenuItem_Click);
            // 
            // bgpanel
            // 
            this.bgpanel.Controls.Add(this.grid);
            this.bgpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgpanel.Location = new System.Drawing.Point(0, 24);
            this.bgpanel.Name = "bgpanel";
            this.bgpanel.Size = new System.Drawing.Size(524, 564);
            this.bgpanel.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackColor = System.Drawing.Color.White;
            this.grid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grid.BackgroundImage")));
            this.grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grid.ColumnCount = 9;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowCount = 9;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid.Size = new System.Drawing.Size(524, 542);
            this.grid.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(83, 17);
            this.statusLabel.Text = "Здравствуйте!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 588);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bgpanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Судоку";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bgpanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПолеToolStripMenuItem;
        private System.Windows.Forms.Panel bgpanel;
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.ToolStripMenuItem создатьПолеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem подсказкаToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem победитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оченьЛегкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оченьСложноToolStripMenuItem;
    }
}

