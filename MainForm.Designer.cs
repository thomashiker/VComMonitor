namespace VComMonitor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SysNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MetroStyleMng = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PortStateGrid = new MetroFramework.Controls.MetroGrid();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.NotifyContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleMng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortStateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SysNotify
            // 
            this.SysNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SysNotify.BalloonTipText = "123213";
            this.SysNotify.BalloonTipTitle = "4646";
            this.SysNotify.ContextMenuStrip = this.NotifyContextMenu;
            this.SysNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("SysNotify.Icon")));
            this.SysNotify.Text = "Virtual Com Monitor";
            this.SysNotify.Visible = true;
            // 
            // NotifyContextMenu
            // 
            this.NotifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.portListToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.NotifyContextMenu.Name = "NotifyContextMenu";
            this.NotifyContextMenu.Size = new System.Drawing.Size(124, 114);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mainToolStripMenuItem.Text = "&Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // portListToolStripMenuItem
            // 
            this.portListToolStripMenuItem.Name = "portListToolStripMenuItem";
            this.portListToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.portListToolStripMenuItem.Text = "&Port List";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.settingToolStripMenuItem.Text = "&Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MetroStyleMng
            // 
            this.MetroStyleMng.Owner = this;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(363, 116);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(7, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 145);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // PortStateGrid
            // 
            this.PortStateGrid.AllowUserToAddRows = false;
            this.PortStateGrid.AllowUserToDeleteRows = false;
            this.PortStateGrid.AllowUserToResizeRows = false;
            this.PortStateGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PortStateGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortStateGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PortStateGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortStateGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PortStateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortStateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Port,
            this.Type,
            this.State});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PortStateGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.PortStateGrid.EnableHeadersVisualStyles = false;
            this.PortStateGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PortStateGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PortStateGrid.Location = new System.Drawing.Point(23, 74);
            this.PortStateGrid.Name = "PortStateGrid";
            this.PortStateGrid.ReadOnly = true;
            this.PortStateGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortStateGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PortStateGrid.RowHeadersVisible = false;
            this.PortStateGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PortStateGrid.RowTemplate.Height = 23;
            this.PortStateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PortStateGrid.Size = new System.Drawing.Size(334, 84);
            this.PortStateGrid.TabIndex = 4;
            // 
            // Port
            // 
            this.Port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Port.DividerWidth = 1;
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DividerWidth = 1;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.State.DividerWidth = 1;
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(363, 74);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(7, 381);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(482, 76);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 480);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.PortStateGrid);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.Text = "Virtual Com Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NotifyContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleMng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortStateGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SysNotify;
        private MetroFramework.Controls.MetroContextMenu NotifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager MetroStyleMng;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroGrid PortStateGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

