
namespace Basic_UI_Creation
{
    partial class Form1
    {
        /// <summary>
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.TextBox();
            this.idvalue = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.statusvalue = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultvalue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 377);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(20, 112);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(64, 15);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Selection 3";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(20, 67);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(64, 15);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Selection 2";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(20, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Selection 1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(537, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 309);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 61);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.Cancel);
            this.panel5.Location = new System.Drawing.Point(120, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 63);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(373, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "CLEAR RESULTS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(199, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "RUN TEST";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Location = new System.Drawing.Point(12, 12);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 32);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "CANCEL";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.menuStrip1);
            this.panel9.Location = new System.Drawing.Point(12, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(664, 35);
            this.panel9.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(172, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1ToolStripMenuItem,
            this.menuItem2ToolStripMenuItem,
            this.menuItem3ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuItem1ToolStripMenuItem
            // 
            this.menuItem1ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem1ToolStripMenuItem.Name = "menuItem1ToolStripMenuItem";
            this.menuItem1ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.menuItem1ToolStripMenuItem.Text = "Menu Item 1";
            // 
            // menuItem2ToolStripMenuItem
            // 
            this.menuItem2ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem2ToolStripMenuItem.Name = "menuItem2ToolStripMenuItem";
            this.menuItem2ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.menuItem2ToolStripMenuItem.Text = "Menu Item 2";
            // 
            // menuItem3ToolStripMenuItem
            // 
            this.menuItem3ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem3ToolStripMenuItem.Name = "menuItem3ToolStripMenuItem";
            this.menuItem3ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.menuItem3ToolStripMenuItem.Text = "Menu Item 3";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1ToolStripMenuItem1,
            this.menuItem2ToolStripMenuItem1,
            this.menuItem3ToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // menuItem1ToolStripMenuItem1
            // 
            this.menuItem1ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem1ToolStripMenuItem1.Name = "menuItem1ToolStripMenuItem1";
            this.menuItem1ToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.menuItem1ToolStripMenuItem1.Text = "Menu Item 1";
            // 
            // menuItem2ToolStripMenuItem1
            // 
            this.menuItem2ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem2ToolStripMenuItem1.Name = "menuItem2ToolStripMenuItem1";
            this.menuItem2ToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.menuItem2ToolStripMenuItem1.Text = "Menu Item 2";
            // 
            // menuItem3ToolStripMenuItem1
            // 
            this.menuItem3ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem3ToolStripMenuItem1.Name = "menuItem3ToolStripMenuItem1";
            this.menuItem3ToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.menuItem3ToolStripMenuItem1.Text = "Menu Item 3";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1ToolStripMenuItem2,
            this.menuItem2ToolStripMenuItem2,
            this.menuItem3ToolStripMenuItem2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuItem1ToolStripMenuItem2
            // 
            this.menuItem1ToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem1ToolStripMenuItem2.Name = "menuItem1ToolStripMenuItem2";
            this.menuItem1ToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.menuItem1ToolStripMenuItem2.Text = "Menu Item 1";
            // 
            // menuItem2ToolStripMenuItem2
            // 
            this.menuItem2ToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem2ToolStripMenuItem2.Name = "menuItem2ToolStripMenuItem2";
            this.menuItem2ToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.menuItem2ToolStripMenuItem2.Text = "Menu Item 2";
            // 
            // menuItem3ToolStripMenuItem2
            // 
            this.menuItem3ToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem3ToolStripMenuItem2.Name = "menuItem3ToolStripMenuItem2";
            this.menuItem3ToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.menuItem3ToolStripMenuItem2.Text = "Menu Item 3";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1ToolStripMenuItem3,
            this.menuItem2ToolStripMenuItem3,
            this.menuItem3ToolStripMenuItem3});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuItem1ToolStripMenuItem3
            // 
            this.menuItem1ToolStripMenuItem3.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem1ToolStripMenuItem3.Name = "menuItem1ToolStripMenuItem3";
            this.menuItem1ToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
            this.menuItem1ToolStripMenuItem3.Text = "Menu Item 1";
            // 
            // menuItem2ToolStripMenuItem3
            // 
            this.menuItem2ToolStripMenuItem3.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem2ToolStripMenuItem3.Name = "menuItem2ToolStripMenuItem3";
            this.menuItem2ToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
            this.menuItem2ToolStripMenuItem3.Text = "Menu Item 2";
            // 
            // menuItem3ToolStripMenuItem3
            // 
            this.menuItem3ToolStripMenuItem3.BackColor = System.Drawing.SystemColors.Window;
            this.menuItem3ToolStripMenuItem3.Name = "menuItem3ToolStripMenuItem3";
            this.menuItem3ToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
            this.menuItem3ToolStripMenuItem3.Text = "Menu Item 3";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.Location = new System.Drawing.Point(120, 39);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(85, 37);
            this.ID.TabIndex = 9;
            // 
            // idvalue
            // 
            this.idvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idvalue.Location = new System.Drawing.Point(199, 39);
            this.idvalue.Multiline = true;
            this.idvalue.Name = "idvalue";
            this.idvalue.Size = new System.Drawing.Size(101, 37);
            this.idvalue.TabIndex = 10;
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.Location = new System.Drawing.Point(295, 39);
            this.Status.Multiline = true;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(113, 37);
            this.Status.TabIndex = 11;
            // 
            // statusvalue
            // 
            this.statusvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusvalue.Location = new System.Drawing.Point(394, 39);
            this.statusvalue.Multiline = true;
            this.statusvalue.Name = "statusvalue";
            this.statusvalue.Size = new System.Drawing.Size(146, 37);
            this.statusvalue.TabIndex = 12;
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.Location = new System.Drawing.Point(120, 72);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(420, 46);
            this.result.TabIndex = 13;
            // 
            // resultvalue
            // 
            this.resultvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultvalue.Location = new System.Drawing.Point(120, 111);
            this.resultvalue.Multiline = true;
            this.resultvalue.Name = "resultvalue";
            this.resultvalue.Size = new System.Drawing.Size(420, 237);
            this.resultvalue.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.resultvalue);
            this.Controls.Add(this.result);
            this.Controls.Add(this.statusvalue);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.idvalue);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 560);
            this.Name = "Form1";
            this.Text = "Basic UI Creation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItem2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItem3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItem2ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItem3ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuItem2ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuItem3ToolStripMenuItem3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox idvalue;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.TextBox statusvalue;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox resultvalue;
    }
}

