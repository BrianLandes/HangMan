﻿namespace HangManGUI {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lettersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.shownWordTextBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.nextWordButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lettersTableLayoutPanel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.shownWordTextBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.45798F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.845798F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.50813F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.188088F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1652, 1040);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lettersTableLayoutPanel
			// 
			this.lettersTableLayoutPanel.ColumnCount = 13;
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691812F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691812F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691812F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691812F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691812F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691812F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.693348F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.694338F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.694338F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691776F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691776F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691776F));
			this.lettersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.691776F));
			this.lettersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lettersTableLayoutPanel.Location = new System.Drawing.Point(6, 788);
			this.lettersTableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
			this.lettersTableLayoutPanel.Name = "lettersTableLayoutPanel";
			this.lettersTableLayoutPanel.RowCount = 2;
			this.lettersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.lettersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.lettersTableLayoutPanel.Size = new System.Drawing.Size(1640, 170);
			this.lettersTableLayoutPanel.TabIndex = 2;
			// 
			// shownWordTextBox
			// 
			this.shownWordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shownWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shownWordTextBox.Location = new System.Drawing.Point(6, 717);
			this.shownWordTextBox.Margin = new System.Windows.Forms.Padding(6);
			this.shownWordTextBox.Name = "shownWordTextBox";
			this.shownWordTextBox.ReadOnly = true;
			this.shownWordTextBox.Size = new System.Drawing.Size(1640, 55);
			this.shownWordTextBox.TabIndex = 1;
			this.shownWordTextBox.TabStop = false;
			this.shownWordTextBox.Text = "SADISM";
			this.shownWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.nextWordButton, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 967);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1646, 70);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// nextWordButton
			// 
			this.nextWordButton.BackColor = System.Drawing.SystemColors.Control;
			this.nextWordButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nextWordButton.Location = new System.Drawing.Point(1099, 3);
			this.nextWordButton.Name = "nextWordButton";
			this.nextWordButton.Size = new System.Drawing.Size(544, 64);
			this.nextWordButton.TabIndex = 0;
			this.nextWordButton.Text = "Next Word";
			this.nextWordButton.UseVisualStyleBackColor = false;
			this.nextWordButton.Click += new System.EventHandler(this.nextWordButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::HangManGUI.Properties.Resources.Stage0;
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1640, 699);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1652, 1040);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainWindow";
			this.Text = "Fetish Hangman";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private void InitializeLetterButtons() {
			lettersButtons = new System.Windows.Forms.Button[26];

			int panelColumns = lettersTableLayoutPanel.ColumnCount;

			for ( int i = 0; i < 26; i ++ ) {
				System.Windows.Forms.Button button = new System.Windows.Forms.Button();
				button.Dock = System.Windows.Forms.DockStyle.Fill;
				button.Location = new System.Drawing.Point(3, 3);
				button.TabStop = false;
				button.Text = "" + (char)(i + 65);
				button.Name = "button" + button.Text;
				button.Size = new System.Drawing.Size(75, 38);
				button.TabIndex = i;
				button.UseVisualStyleBackColor = true;
				button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				button.ForeColor = System.Drawing.Color.Blue;
				button.Click += new System.EventHandler(this.letterButton_Click);

				lettersButtons[i] = button;

				int row = (int)(i / panelColumns);
				int col = (int)(i % panelColumns);

				this.lettersTableLayoutPanel.Controls.Add(button, col, row);
			}
		}

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox shownWordTextBox;
		private System.Windows.Forms.TableLayoutPanel lettersTableLayoutPanel;
		private System.Windows.Forms.Button[] lettersButtons;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button nextWordButton;
	}
}

