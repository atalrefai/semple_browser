namespace restClient_0
{
    partial class Form1
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtRequestURI = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.responcemsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.alerts = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFavoretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modefyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modefyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(9, 238);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(157, 226);
            this.txtResponse.TabIndex = 2;
            this.txtResponse.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.txtRequestURI,
            this.goToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.favoretToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(948, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtRequestURI
            // 
            this.txtRequestURI.Name = "txtRequestURI";
            this.txtRequestURI.Size = new System.Drawing.Size(301, 24);
            this.txtRequestURI.Text = "http://www.atalrefai.com";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.responcemsg,
            this.alerts,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.ip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(948, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // responcemsg
            // 
            this.responcemsg.Name = "responcemsg";
            this.responcemsg.Size = new System.Drawing.Size(0, 17);
            // 
            // alerts
            // 
            this.alerts.Name = "alerts";
            this.alerts.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = "My IP:";
            // 
            // ip
            // 
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(17, 17);
            this.ip.Text = "ip";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 434);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(712, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 434);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 434);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(233, 434);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripMenuItem.Image = global::restClient_0.Properties.Resources.ww1;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Image = global::restClient_0.Properties.Resources.go;
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.goToolStripMenuItem.Text = "&GO";
            this.goToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::restClient_0.Properties.Resources.refresh_icon;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // favoretToolStripMenuItem
            // 
            this.favoretToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFavoretToolStripMenuItem,
            this.addToFavoretToolStripMenuItem,
            this.modefyToolStripMenuItem});
            this.favoretToolStripMenuItem.Image = global::restClient_0.Properties.Resources.favorite_icon;
            this.favoretToolStripMenuItem.Name = "favoretToolStripMenuItem";
            this.favoretToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.favoretToolStripMenuItem.Text = "&Favoret";
            this.favoretToolStripMenuItem.Click += new System.EventHandler(this.favoretToolStripMenuItem_Click);
            // 
            // addToFavoretToolStripMenuItem
            // 
            this.addToFavoretToolStripMenuItem.Name = "addToFavoretToolStripMenuItem";
            this.addToFavoretToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addToFavoretToolStripMenuItem.Text = "Add To Favoret";
            this.addToFavoretToolStripMenuItem.Click += new System.EventHandler(this.addToFavoretToolStripMenuItem_Click);
            // 
            // showFavoretToolStripMenuItem
            // 
            this.showFavoretToolStripMenuItem.Name = "showFavoretToolStripMenuItem";
            this.showFavoretToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.showFavoretToolStripMenuItem.Text = "Show Favoret";
            this.showFavoretToolStripMenuItem.Click += new System.EventHandler(this.showFavoretToolStripMenuItem_Click);
            // 
            // modefyToolStripMenuItem
            // 
            this.modefyToolStripMenuItem.Name = "modefyToolStripMenuItem";
            this.modefyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.modefyToolStripMenuItem.Text = "Modefy";
            this.modefyToolStripMenuItem.Click += new System.EventHandler(this.modefyToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHistoryToolStripMenuItem,
            this.addToHistoryToolStripMenuItem1,
            this.modefyToolStripMenuItem1});
            this.historyToolStripMenuItem.Image = global::restClient_0.Properties.Resources.h;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.historyToolStripMenuItem.Text = "&History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // showHistoryToolStripMenuItem
            // 
            this.showHistoryToolStripMenuItem.Name = "showHistoryToolStripMenuItem";
            this.showHistoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showHistoryToolStripMenuItem.Text = "Show History";
            this.showHistoryToolStripMenuItem.Click += new System.EventHandler(this.showHistoryToolStripMenuItem_Click);
            // 
            // addToHistoryToolStripMenuItem1
            // 
            this.addToHistoryToolStripMenuItem1.Name = "addToHistoryToolStripMenuItem1";
            this.addToHistoryToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToHistoryToolStripMenuItem1.Text = "Add to history";
            this.addToHistoryToolStripMenuItem1.Click += new System.EventHandler(this.addToHistoryToolStripMenuItem1_Click);
            // 
            // modefyToolStripMenuItem1
            // 
            this.modefyToolStripMenuItem1.Name = "modefyToolStripMenuItem1";
            this.modefyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.modefyToolStripMenuItem1.Text = "Modefy";
            this.modefyToolStripMenuItem1.Click += new System.EventHandler(this.modefyToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c# Browser By:Abdulrahman Alrifai - ID:H00300001";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtRequestURI;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripStatusLabel responcemsg;
        private System.Windows.Forms.ToolStripStatusLabel alerts;
        private System.Windows.Forms.ToolStripMenuItem favoretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripStatusLabel ip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToHistoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToFavoretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFavoretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modefyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modefyToolStripMenuItem1;
    }
}

