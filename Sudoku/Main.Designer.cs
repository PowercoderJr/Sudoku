﻿namespace Sudoku
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
            this.начатьСначалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьОшибкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgpanel = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.bgpanel.SuspendLayout();
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
            this.начатьСначалаToolStripMenuItem,
            this.проверитьОшибкиToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьСначалаToolStripMenuItem
            // 
            this.начатьСначалаToolStripMenuItem.Name = "начатьСначалаToolStripMenuItem";
            this.начатьСначалаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.начатьСначалаToolStripMenuItem.Text = "Начать сначала";
            this.начатьСначалаToolStripMenuItem.Click += new System.EventHandler(this.начатьСначалаToolStripMenuItem_Click);
            // 
            // проверитьОшибкиToolStripMenuItem
            // 
            this.проверитьОшибкиToolStripMenuItem.Enabled = false;
            this.проверитьОшибкиToolStripMenuItem.Name = "проверитьОшибкиToolStripMenuItem";
            this.проверитьОшибкиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.проверитьОшибкиToolStripMenuItem.Text = "Проверить ошибки";
            // 
            // bgpanel
            // 
            this.bgpanel.Controls.Add(this.grid);
            this.bgpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgpanel.Location = new System.Drawing.Point(0, 24);
            this.bgpanel.Name = "bgpanel";
            this.bgpanel.Size = new System.Drawing.Size(524, 524);
            this.bgpanel.TabIndex = 2;
            // 
            // grid
            // 
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
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.grid.Size = new System.Drawing.Size(524, 524);
            this.grid.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 548);
            this.Controls.Add(this.bgpanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Судоку";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bgpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьСначалаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьОшибкиToolStripMenuItem;
        private System.Windows.Forms.Panel bgpanel;
        private System.Windows.Forms.TableLayoutPanel grid;
    }
}
