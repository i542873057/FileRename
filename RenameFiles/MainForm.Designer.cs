namespace RenameFiles
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.RenameRadioButton = new System.Windows.Forms.RadioButton();
            this.ExtensionRadioButton = new System.Windows.Forms.RadioButton();
            this.ExtensionTargetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtensionSrcTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteKeywordRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteKeywordTextBox = new System.Windows.Forms.TextBox();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.NewPreRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.NewPreTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ReplacePreRadioButton = new System.Windows.Forms.RadioButton();
            this.ReplaceSrcTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ReplaceTargetTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.AllowDrop = true;
            this.FolderPathTextBox.Location = new System.Drawing.Point(111, 8);
            this.FolderPathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.Size = new System.Drawing.Size(400, 25);
            this.FolderPathTextBox.TabIndex = 0;
            this.FolderPathTextBox.TextChanged += new System.EventHandler(this.FolderPathTextBox_TextChanged);
            this.FolderPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FolderPathTextBox_DragDrop);
            this.FolderPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FolderPathTextBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "文件夹路径";
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.AutoSize = true;
            this.btSelectFolder.Location = new System.Drawing.Point(520, 5);
            this.btSelectFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(55, 29);
            this.btSelectFolder.TabIndex = 1;
            this.btSelectFolder.Text = "选择";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // btStart
            // 
            this.btStart.AutoSize = true;
            this.btStart.Enabled = false;
            this.btStart.Location = new System.Drawing.Point(575, 337);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(89, 60);
            this.btStart.TabIndex = 12;
            this.btStart.Text = "开始";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // RenameRadioButton
            // 
            this.RenameRadioButton.AutoSize = true;
            this.RenameRadioButton.Location = new System.Drawing.Point(20, 136);
            this.RenameRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RenameRadioButton.Name = "RenameRadioButton";
            this.RenameRadioButton.Size = new System.Drawing.Size(103, 19);
            this.RenameRadioButton.TabIndex = 5;
            this.RenameRadioButton.TabStop = true;
            this.RenameRadioButton.Text = "重命名文件";
            this.RenameRadioButton.UseVisualStyleBackColor = true;
            this.RenameRadioButton.CheckedChanged += new System.EventHandler(this.RenameRadioButton_CheckedChanged);
            // 
            // ExtensionRadioButton
            // 
            this.ExtensionRadioButton.AutoSize = true;
            this.ExtensionRadioButton.Checked = true;
            this.ExtensionRadioButton.Location = new System.Drawing.Point(20, 86);
            this.ExtensionRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtensionRadioButton.Name = "ExtensionRadioButton";
            this.ExtensionRadioButton.Size = new System.Drawing.Size(103, 19);
            this.ExtensionRadioButton.TabIndex = 2;
            this.ExtensionRadioButton.TabStop = true;
            this.ExtensionRadioButton.Text = "修改扩展名";
            this.ExtensionRadioButton.UseVisualStyleBackColor = true;
            this.ExtensionRadioButton.CheckedChanged += new System.EventHandler(this.ExtensionRadioButton_CheckedChanged);
            // 
            // ExtensionTargetTextBox
            // 
            this.ExtensionTargetTextBox.Location = new System.Drawing.Point(332, 85);
            this.ExtensionTargetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtensionTargetTextBox.Name = "ExtensionTargetTextBox";
            this.ExtensionTargetTextBox.Size = new System.Drawing.Size(153, 25);
            this.ExtensionTargetTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "-->";
            // 
            // ExtensionSrcTextBox
            // 
            this.ExtensionSrcTextBox.Location = new System.Drawing.Point(141, 85);
            this.ExtensionSrcTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtensionSrcTextBox.Name = "ExtensionSrcTextBox";
            this.ExtensionSrcTextBox.Size = new System.Drawing.Size(137, 25);
            this.ExtensionSrcTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "(新文件名称前缀)";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Enabled = false;
            this.RenameTextBox.Location = new System.Drawing.Point(141, 135);
            this.RenameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(245, 25);
            this.RenameTextBox.TabIndex = 6;
            // 
            // DeleteKeywordRadioButton
            // 
            this.DeleteKeywordRadioButton.AutoSize = true;
            this.DeleteKeywordRadioButton.Location = new System.Drawing.Point(20, 184);
            this.DeleteKeywordRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteKeywordRadioButton.Name = "DeleteKeywordRadioButton";
            this.DeleteKeywordRadioButton.Size = new System.Drawing.Size(103, 19);
            this.DeleteKeywordRadioButton.TabIndex = 7;
            this.DeleteKeywordRadioButton.TabStop = true;
            this.DeleteKeywordRadioButton.Text = "删除关键字";
            this.DeleteKeywordRadioButton.UseVisualStyleBackColor = true;
            this.DeleteKeywordRadioButton.CheckedChanged += new System.EventHandler(this.DeleteKeywordRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "(要删除的关键字)";
            // 
            // DeleteKeywordTextBox
            // 
            this.DeleteKeywordTextBox.Enabled = false;
            this.DeleteKeywordTextBox.Location = new System.Drawing.Point(139, 182);
            this.DeleteKeywordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteKeywordTextBox.Name = "DeleteKeywordTextBox";
            this.DeleteKeywordTextBox.Size = new System.Drawing.Size(245, 25);
            this.DeleteKeywordTextBox.TabIndex = 8;
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Location = new System.Drawing.Point(18, 359);
            this.TopMostCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(104, 19);
            this.TopMostCheckBox.TabIndex = 11;
            this.TopMostCheckBox.Text = "总在最上层";
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // NewPreRadioButton
            // 
            this.NewPreRadioButton.AutoSize = true;
            this.NewPreRadioButton.Location = new System.Drawing.Point(20, 236);
            this.NewPreRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPreRadioButton.Name = "NewPreRadioButton";
            this.NewPreRadioButton.Size = new System.Drawing.Size(88, 19);
            this.NewPreRadioButton.TabIndex = 9;
            this.NewPreRadioButton.TabStop = true;
            this.NewPreRadioButton.Text = "添加前缀";
            this.NewPreRadioButton.UseVisualStyleBackColor = true;
            this.NewPreRadioButton.CheckedChanged += new System.EventHandler(this.NewPreRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "(要添加的文件名前缀)";
            // 
            // NewPreTextBox
            // 
            this.NewPreTextBox.Enabled = false;
            this.NewPreTextBox.Location = new System.Drawing.Point(139, 235);
            this.NewPreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPreTextBox.Name = "NewPreTextBox";
            this.NewPreTextBox.Size = new System.Drawing.Size(245, 25);
            this.NewPreTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "(扩展名)";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(140, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 25);
            this.textBox1.TabIndex = 32;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 41);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 19);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "新建扩展名";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ReplacePreRadioButton
            // 
            this.ReplacePreRadioButton.AutoSize = true;
            this.ReplacePreRadioButton.Location = new System.Drawing.Point(20, 287);
            this.ReplacePreRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReplacePreRadioButton.Name = "ReplacePreRadioButton";
            this.ReplacePreRadioButton.Size = new System.Drawing.Size(103, 19);
            this.ReplacePreRadioButton.TabIndex = 34;
            this.ReplacePreRadioButton.TabStop = true;
            this.ReplacePreRadioButton.Text = "替换文件名";
            this.ReplacePreRadioButton.UseVisualStyleBackColor = true;
            this.ReplacePreRadioButton.CheckedChanged += new System.EventHandler(this.ReplacePreRadioButton_CheckedChanged);
            // 
            // ReplaceSrcTextBox
            // 
            this.ReplaceSrcTextBox.Enabled = false;
            this.ReplaceSrcTextBox.Location = new System.Drawing.Point(139, 281);
            this.ReplaceSrcTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReplaceSrcTextBox.Name = "ReplaceSrcTextBox";
            this.ReplaceSrcTextBox.Size = new System.Drawing.Size(139, 25);
            this.ReplaceSrcTextBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "(要替换的内容部分)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "-->";
            // 
            // ReplaceTargetTextBox
            // 
            this.ReplaceTargetTextBox.Enabled = false;
            this.ReplaceTargetTextBox.Location = new System.Drawing.Point(332, 281);
            this.ReplaceTargetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReplaceTargetTextBox.Name = "ReplaceTargetTextBox";
            this.ReplaceTargetTextBox.Size = new System.Drawing.Size(153, 25);
            this.ReplaceTargetTextBox.TabIndex = 38;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 421);
            this.Controls.Add(this.ReplaceTargetTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReplaceSrcTextBox);
            this.Controls.Add(this.ReplacePreRadioButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ExtensionTargetTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExtensionRadioButton);
            this.Controls.Add(this.ExtensionSrcTextBox);
            this.Controls.Add(this.DeleteKeywordTextBox);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.DeleteKeywordRadioButton);
            this.Controls.Add(this.RenameRadioButton);
            this.Controls.Add(this.NewPreRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TopMostCheckBox);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btSelectFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量修改文件名称工具";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FolderPathTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btSelectFolder;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.RadioButton RenameRadioButton;
		private System.Windows.Forms.RadioButton ExtensionRadioButton;
		private System.Windows.Forms.TextBox ExtensionSrcTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ExtensionTargetTextBox;
		private System.Windows.Forms.TextBox RenameTextBox;
		private System.Windows.Forms.RadioButton DeleteKeywordRadioButton;
		private System.Windows.Forms.TextBox DeleteKeywordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox TopMostCheckBox;
		private System.Windows.Forms.RadioButton NewPreRadioButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox NewPreTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton ReplacePreRadioButton;
        private System.Windows.Forms.TextBox ReplaceSrcTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReplaceTargetTextBox;
    }
}

