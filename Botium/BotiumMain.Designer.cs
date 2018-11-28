namespace Botium
{
    partial class BotiumMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.homeBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mapBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 404);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.homeBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // homeBrowser
            // 
            this.homeBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeBrowser.Location = new System.Drawing.Point(3, 3);
            this.homeBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.homeBrowser.Name = "homeBrowser";
            this.homeBrowser.ScriptErrorsSuppressed = true;
            this.homeBrowser.Size = new System.Drawing.Size(770, 372);
            this.homeBrowser.TabIndex = 0;
            this.homeBrowser.Url = new System.Uri("http://lp.darkorbit.com", System.UriKind.Absolute);
            this.homeBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.homeBrowser_Navigated);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mapBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mapBrowser
            // 
            this.mapBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapBrowser.Location = new System.Drawing.Point(3, 3);
            this.mapBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapBrowser.Name = "mapBrowser";
            this.mapBrowser.ScriptErrorsSuppressed = true;
            this.mapBrowser.Size = new System.Drawing.Size(770, 372);
            this.mapBrowser.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage3.Controls.Add(this.loginGroupBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.passLabel);
            this.loginGroupBox.Controls.Add(this.passBox);
            this.loginGroupBox.Controls.Add(this.idBox);
            this.loginGroupBox.Controls.Add(this.idLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(7, 5);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(163, 74);
            this.loginGroupBox.TabIndex = 2;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(6, 40);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(30, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Pass";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(41, 42);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 1;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(41, 16);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 16);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.consoleBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleBox.Location = new System.Drawing.Point(0, 437);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(784, 125);
            this.consoleBox.TabIndex = 2;
            this.consoleBox.Text = "";
            // 
            // BotiumMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BotiumMain";
            this.Text = "Botium";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.WebBrowser homeBrowser;
        private System.Windows.Forms.WebBrowser mapBrowser;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idLabel;
    }
}

