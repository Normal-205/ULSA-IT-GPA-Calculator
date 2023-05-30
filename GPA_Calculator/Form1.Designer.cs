namespace FirstProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.insertDataButton = new System.Windows.Forms.Button();
            this.lbNormal = new System.Windows.Forms.Label();
            this.listMarkListBox = new System.Windows.Forms.ListBox();
            this.midMarkTextBox = new System.Windows.Forms.TextBox();
            this.midMarkLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.ulsaitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listResultListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.summaryButton = new System.Windows.Forms.Button();
            this.lastMarkLabel = new System.Windows.Forms.Label();
            this.lastMarkTextBox = new System.Windows.Forms.TextBox();
            this.creditsTextBox = new System.Windows.Forms.TextBox();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.summaryListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertDataButton
            // 
            this.insertDataButton.BackColor = System.Drawing.Color.White;
            this.insertDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertDataButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDataButton.Location = new System.Drawing.Point(38, 224);
            this.insertDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertDataButton.Name = "insertDataButton";
            this.insertDataButton.Size = new System.Drawing.Size(170, 64);
            this.insertDataButton.TabIndex = 4;
            this.insertDataButton.Text = "Nhập Điểm";
            this.insertDataButton.UseVisualStyleBackColor = false;
            this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
            // 
            // lbNormal
            // 
            this.lbNormal.AutoSize = true;
            this.lbNormal.BackColor = System.Drawing.Color.Transparent;
            this.lbNormal.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNormal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbNormal.Location = new System.Drawing.Point(297, 1);
            this.lbNormal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNormal.Name = "lbNormal";
            this.lbNormal.Size = new System.Drawing.Size(349, 41);
            this.lbNormal.TabIndex = 11;
            this.lbNormal.Text = "Phần Mềm Tính GPA";
            this.lbNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listMarkListBox
            // 
            this.listMarkListBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMarkListBox.FormattingEnabled = true;
            this.listMarkListBox.ItemHeight = 23;
            this.listMarkListBox.Location = new System.Drawing.Point(11, 31);
            this.listMarkListBox.Margin = new System.Windows.Forms.Padding(2);
            this.listMarkListBox.Name = "listMarkListBox";
            this.listMarkListBox.Size = new System.Drawing.Size(361, 165);
            this.listMarkListBox.TabIndex = 8;
            this.listMarkListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // midMarkTextBox
            // 
            this.midMarkTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midMarkTextBox.Location = new System.Drawing.Point(185, 53);
            this.midMarkTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.midMarkTextBox.Name = "midMarkTextBox";
            this.midMarkTextBox.Size = new System.Drawing.Size(54, 29);
            this.midMarkTextBox.TabIndex = 1;
            this.midMarkTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.midMarkTextBox_KeyDown);
            this.midMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MarkTextBox_KeyPress);
            // 
            // midMarkLabel
            // 
            this.midMarkLabel.AutoSize = true;
            this.midMarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.midMarkLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midMarkLabel.ForeColor = System.Drawing.Color.Black;
            this.midMarkLabel.Location = new System.Drawing.Point(34, 55);
            this.midMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.midMarkLabel.Name = "midMarkLabel";
            this.midMarkLabel.Size = new System.Drawing.Size(143, 22);
            this.midMarkLabel.TabIndex = 4;
            this.midMarkLabel.Text = "Điểm Quá Trình";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(38, 304);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(170, 64);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Xoá dòng";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.delete_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(38, 387);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(170, 64);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyrightLabel.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Location = new System.Drawing.Point(75, 598);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(322, 30);
            this.copyrightLabel.TabIndex = 8;
            this.copyrightLabel.Text = "Copyright © 2023 by ";
            // 
            // ulsaitLinkLabel
            // 
            this.ulsaitLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ulsaitLinkLabel.AutoSize = true;
            this.ulsaitLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ulsaitLinkLabel.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulsaitLinkLabel.Location = new System.Drawing.Point(401, 598);
            this.ulsaitLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ulsaitLinkLabel.Name = "ulsaitLinkLabel";
            this.ulsaitLinkLabel.Size = new System.Drawing.Size(117, 30);
            this.ulsaitLinkLabel.TabIndex = 10;
            this.ulsaitLinkLabel.TabStop = true;
            this.ulsaitLinkLabel.Text = "USLA IT";
            this.ulsaitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ulsaitLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 598);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "All right reserved.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listMarkListBox);
            this.groupBox1.Controls.Add(this.listResultListBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(306, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(611, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các Môn Học";
            // 
            // listResultListBox
            // 
            this.listResultListBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultListBox.FormattingEnabled = true;
            this.listResultListBox.ItemHeight = 23;
            this.listResultListBox.Location = new System.Drawing.Point(376, 31);
            this.listResultListBox.Margin = new System.Windows.Forms.Padding(2);
            this.listResultListBox.Name = "listResultListBox";
            this.listResultListBox.Size = new System.Drawing.Size(225, 165);
            this.listResultListBox.TabIndex = 8;
            this.listResultListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(353, 494);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(353, 494);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 12;
            // 
            // summaryButton
            // 
            this.summaryButton.BackColor = System.Drawing.Color.White;
            this.summaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.summaryButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.Location = new System.Drawing.Point(38, 465);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(170, 64);
            this.summaryButton.TabIndex = 7;
            this.summaryButton.Text = "Kết quả";
            this.summaryButton.UseVisualStyleBackColor = false;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // lastMarkLabel
            // 
            this.lastMarkLabel.AutoSize = true;
            this.lastMarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastMarkLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastMarkLabel.ForeColor = System.Drawing.Color.Black;
            this.lastMarkLabel.Location = new System.Drawing.Point(34, 93);
            this.lastMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastMarkLabel.Name = "lastMarkLabel";
            this.lastMarkLabel.Size = new System.Drawing.Size(125, 22);
            this.lastMarkLabel.TabIndex = 13;
            this.lastMarkLabel.Text = "Điểm Cuối Kỳ";
            // 
            // lastMarkTextBox
            // 
            this.lastMarkTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastMarkTextBox.Location = new System.Drawing.Point(185, 90);
            this.lastMarkTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastMarkTextBox.Name = "lastMarkTextBox";
            this.lastMarkTextBox.Size = new System.Drawing.Size(54, 29);
            this.lastMarkTextBox.TabIndex = 2;
            this.lastMarkTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastMarkTextBox_KeyDown);
            this.lastMarkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MarkTextBox_KeyPress);
            // 
            // creditsTextBox
            // 
            this.creditsTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsTextBox.Location = new System.Drawing.Point(185, 139);
            this.creditsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.creditsTextBox.Name = "creditsTextBox";
            this.creditsTextBox.Size = new System.Drawing.Size(54, 29);
            this.creditsTextBox.TabIndex = 3;
            this.creditsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.creditsTextBox_KeyDown);
            this.creditsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MarkTextBox_KeyPress);
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditsLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.ForeColor = System.Drawing.Color.Black;
            this.creditsLabel.Location = new System.Drawing.Point(36, 142);
            this.creditsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(98, 22);
            this.creditsLabel.TabIndex = 16;
            this.creditsLabel.Text = "Số Tín Chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.summaryListBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(306, 331);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(611, 222);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Kết";
            // 
            // summaryListBox
            // 
            this.summaryListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.summaryListBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryListBox.FormattingEnabled = true;
            this.summaryListBox.ItemHeight = 23;
            this.summaryListBox.Location = new System.Drawing.Point(11, 31);
            this.summaryListBox.Margin = new System.Windows.Forms.Padding(2);
            this.summaryListBox.Name = "summaryListBox";
            this.summaryListBox.Size = new System.Drawing.Size(590, 165);
            this.summaryListBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "( Dùng dấu . để viết điểm phẩy )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(696, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dưới 1.0 hệ 4 là tạch nha!";
            // 
            // Dashboard
            // 
            this.AcceptButton = this.insertDataButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.ulsaitLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.creditsTextBox);
            this.Controls.Add(this.lastMarkTextBox);
            this.Controls.Add(this.lastMarkLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.midMarkLabel);
            this.Controls.Add(this.midMarkTextBox);
            this.Controls.Add(this.lbNormal);
            this.Controls.Add(this.insertDataButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertDataButton;
        private System.Windows.Forms.Label lbNormal;
        private System.Windows.Forms.ListBox listMarkListBox;
        private System.Windows.Forms.TextBox midMarkTextBox;
        private System.Windows.Forms.Label midMarkLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.LinkLabel ulsaitLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Label lastMarkLabel;
        private System.Windows.Forms.TextBox lastMarkTextBox;
        private System.Windows.Forms.TextBox creditsTextBox;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox summaryListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listResultListBox;
        private System.Windows.Forms.Label label3;
    }
}

