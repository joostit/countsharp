namespace BrrrBayBay.CountSharp
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
			this.selectDirectoryButton = new System.Windows.Forms.Button();
			this.resultsGroup = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.emptyPercentBox = new System.Windows.Forms.Label();
			this.totalCommentsPercentBox = new System.Windows.Forms.Label();
			this.xCommentsPercentBox = new System.Windows.Forms.Label();
			this.sCommentsPercentBox = new System.Windows.Forms.Label();
			this.codePercentBox = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.totalCountBox = new System.Windows.Forms.Label();
			this.emptyCountBox = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.totalCommentsCountBox = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.xCommentsCountBox = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.sCommentsCountBox = new System.Windows.Forms.Label();
			this.codeCountBox = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.scanningLabel = new System.Windows.Forms.Label();
			this.fileCountLabel = new System.Windows.Forms.Label();
			this.resultsGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectDirectoryButton
			// 
			this.selectDirectoryButton.Location = new System.Drawing.Point(164, 253);
			this.selectDirectoryButton.Name = "selectDirectoryButton";
			this.selectDirectoryButton.Size = new System.Drawing.Size(142, 23);
			this.selectDirectoryButton.TabIndex = 0;
			this.selectDirectoryButton.Text = "Open solution directory";
			this.selectDirectoryButton.UseVisualStyleBackColor = true;
			this.selectDirectoryButton.Click += new System.EventHandler(this.selectDirectoryButton_Click);
			// 
			// resultsGroup
			// 
			this.resultsGroup.Controls.Add(this.label16);
			this.resultsGroup.Controls.Add(this.label15);
			this.resultsGroup.Controls.Add(this.label14);
			this.resultsGroup.Controls.Add(this.label13);
			this.resultsGroup.Controls.Add(this.label12);
			this.resultsGroup.Controls.Add(this.emptyPercentBox);
			this.resultsGroup.Controls.Add(this.totalCommentsPercentBox);
			this.resultsGroup.Controls.Add(this.xCommentsPercentBox);
			this.resultsGroup.Controls.Add(this.sCommentsPercentBox);
			this.resultsGroup.Controls.Add(this.codePercentBox);
			this.resultsGroup.Controls.Add(this.label11);
			this.resultsGroup.Controls.Add(this.label9);
			this.resultsGroup.Controls.Add(this.totalCountBox);
			this.resultsGroup.Controls.Add(this.emptyCountBox);
			this.resultsGroup.Controls.Add(this.label7);
			this.resultsGroup.Controls.Add(this.totalCommentsCountBox);
			this.resultsGroup.Controls.Add(this.label5);
			this.resultsGroup.Controls.Add(this.xCommentsCountBox);
			this.resultsGroup.Controls.Add(this.label4);
			this.resultsGroup.Controls.Add(this.sCommentsCountBox);
			this.resultsGroup.Controls.Add(this.codeCountBox);
			this.resultsGroup.Controls.Add(this.label1);
			this.resultsGroup.Enabled = false;
			this.resultsGroup.Location = new System.Drawing.Point(12, 12);
			this.resultsGroup.Name = "resultsGroup";
			this.resultsGroup.Size = new System.Drawing.Size(294, 209);
			this.resultsGroup.TabIndex = 1;
			this.resultsGroup.TabStop = false;
			this.resultsGroup.Text = "Line count";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(273, 142);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(15, 13);
			this.label16.TabIndex = 26;
			this.label16.Text = "%";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(273, 107);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(15, 13);
			this.label15.TabIndex = 25;
			this.label15.Text = "%";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(273, 81);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(15, 13);
			this.label14.TabIndex = 24;
			this.label14.Text = "%";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(273, 55);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(15, 13);
			this.label13.TabIndex = 23;
			this.label13.Text = "%";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(273, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(15, 13);
			this.label12.TabIndex = 4;
			this.label12.Text = "%";
			// 
			// emptyPercentBox
			// 
			this.emptyPercentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emptyPercentBox.Location = new System.Drawing.Point(223, 138);
			this.emptyPercentBox.Name = "emptyPercentBox";
			this.emptyPercentBox.Size = new System.Drawing.Size(44, 20);
			this.emptyPercentBox.TabIndex = 22;
			this.emptyPercentBox.Text = "-";
			this.emptyPercentBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// totalCommentsPercentBox
			// 
			this.totalCommentsPercentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.totalCommentsPercentBox.Location = new System.Drawing.Point(223, 103);
			this.totalCommentsPercentBox.Name = "totalCommentsPercentBox";
			this.totalCommentsPercentBox.Size = new System.Drawing.Size(44, 20);
			this.totalCommentsPercentBox.TabIndex = 21;
			this.totalCommentsPercentBox.Text = "-";
			this.totalCommentsPercentBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// xCommentsPercentBox
			// 
			this.xCommentsPercentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.xCommentsPercentBox.Location = new System.Drawing.Point(223, 77);
			this.xCommentsPercentBox.Name = "xCommentsPercentBox";
			this.xCommentsPercentBox.Size = new System.Drawing.Size(44, 20);
			this.xCommentsPercentBox.TabIndex = 20;
			this.xCommentsPercentBox.Text = "-";
			this.xCommentsPercentBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sCommentsPercentBox
			// 
			this.sCommentsPercentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sCommentsPercentBox.Location = new System.Drawing.Point(223, 51);
			this.sCommentsPercentBox.Name = "sCommentsPercentBox";
			this.sCommentsPercentBox.Size = new System.Drawing.Size(44, 20);
			this.sCommentsPercentBox.TabIndex = 19;
			this.sCommentsPercentBox.Text = "-";
			this.sCommentsPercentBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// codePercentBox
			// 
			this.codePercentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.codePercentBox.Location = new System.Drawing.Point(223, 16);
			this.codePercentBox.Name = "codePercentBox";
			this.codePercentBox.Size = new System.Drawing.Size(44, 20);
			this.codePercentBox.TabIndex = 18;
			this.codePercentBox.Text = "-";
			this.codePercentBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(6, 173);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(105, 20);
			this.label11.TabIndex = 11;
			this.label11.Text = "Total line count:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(105, 20);
			this.label9.TabIndex = 17;
			this.label9.Text = "Empty lines:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// totalCountBox
			// 
			this.totalCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.totalCountBox.Location = new System.Drawing.Point(117, 173);
			this.totalCountBox.Name = "totalCountBox";
			this.totalCountBox.Size = new System.Drawing.Size(100, 20);
			this.totalCountBox.TabIndex = 9;
			this.totalCountBox.Text = "-";
			this.totalCountBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// emptyCountBox
			// 
			this.emptyCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emptyCountBox.Location = new System.Drawing.Point(117, 138);
			this.emptyCountBox.Name = "emptyCountBox";
			this.emptyCountBox.Size = new System.Drawing.Size(100, 20);
			this.emptyCountBox.TabIndex = 15;
			this.emptyCountBox.Text = "-";
			this.emptyCountBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 103);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "Total comments:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// totalCommentsCountBox
			// 
			this.totalCommentsCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.totalCommentsCountBox.Location = new System.Drawing.Point(117, 103);
			this.totalCommentsCountBox.Name = "totalCommentsCountBox";
			this.totalCommentsCountBox.Size = new System.Drawing.Size(100, 20);
			this.totalCommentsCountBox.TabIndex = 12;
			this.totalCommentsCountBox.Text = "-";
			this.totalCommentsCountBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "XML comments:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// xCommentsCountBox
			// 
			this.xCommentsCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.xCommentsCountBox.Location = new System.Drawing.Point(117, 77);
			this.xCommentsCountBox.Name = "xCommentsCountBox";
			this.xCommentsCountBox.Size = new System.Drawing.Size(100, 20);
			this.xCommentsCountBox.TabIndex = 9;
			this.xCommentsCountBox.Text = "-";
			this.xCommentsCountBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Standard comments:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// sCommentsCountBox
			// 
			this.sCommentsCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sCommentsCountBox.Location = new System.Drawing.Point(117, 51);
			this.sCommentsCountBox.Name = "sCommentsCountBox";
			this.sCommentsCountBox.Size = new System.Drawing.Size(100, 20);
			this.sCommentsCountBox.TabIndex = 3;
			this.sCommentsCountBox.Text = "-";
			this.sCommentsCountBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// codeCountBox
			// 
			this.codeCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.codeCountBox.Location = new System.Drawing.Point(117, 16);
			this.codeCountBox.Name = "codeCountBox";
			this.codeCountBox.Size = new System.Drawing.Size(100, 20);
			this.codeCountBox.TabIndex = 2;
			this.codeCountBox.Text = "-";
			this.codeCountBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Code lines:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 253);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(294, 23);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 2;
			this.progressBar.Visible = false;
			// 
			// scanningLabel
			// 
			this.scanningLabel.AutoSize = true;
			this.scanningLabel.Location = new System.Drawing.Point(9, 258);
			this.scanningLabel.Name = "scanningLabel";
			this.scanningLabel.Size = new System.Drawing.Size(121, 13);
			this.scanningLabel.TabIndex = 3;
			this.scanningLabel.Text = "Searching for *.cs files...";
			this.scanningLabel.Visible = false;
			// 
			// fileCountLabel
			// 
			this.fileCountLabel.Location = new System.Drawing.Point(12, 224);
			this.fileCountLabel.Name = "fileCountLabel";
			this.fileCountLabel.Size = new System.Drawing.Size(294, 19);
			this.fileCountLabel.TabIndex = 4;
			this.fileCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 288);
			this.Controls.Add(this.fileCountLabel);
			this.Controls.Add(this.scanningLabel);
			this.Controls.Add(this.selectDirectoryButton);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.resultsGroup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.Text = "Count Sharp";
			this.resultsGroup.ResumeLayout(false);
			this.resultsGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button selectDirectoryButton;
		private System.Windows.Forms.GroupBox resultsGroup;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label totalCountBox;
		private System.Windows.Forms.Label emptyCountBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label totalCommentsCountBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label xCommentsCountBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label sCommentsCountBox;
		private System.Windows.Forms.Label codeCountBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label scanningLabel;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label emptyPercentBox;
		private System.Windows.Forms.Label totalCommentsPercentBox;
		private System.Windows.Forms.Label xCommentsPercentBox;
		private System.Windows.Forms.Label sCommentsPercentBox;
		private System.Windows.Forms.Label codePercentBox;
		private System.Windows.Forms.Label fileCountLabel;
	}
}

