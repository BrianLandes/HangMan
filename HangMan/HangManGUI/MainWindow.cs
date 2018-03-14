using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGUI {
	public partial class MainWindow : Form {

		private Image[] images;

		public MainWindow() {
			InitializeComponent();
			InitializeLetterButtons();
			InitializeProgressBoxes();
			images = new Image[4];
			images[0] = Properties.Resources.Stage0;
			images[1] = Properties.Resources.Stage1;
			images[2] = Properties.Resources.Stage2;
			images[3] = Properties.Resources.Stage3;
		}

		public Action<string> OnLetterButton;

		public Action OnNextWordButton;

		public string ShownWord {
			set {
				shownWordTextBox.Text = value.ToUpper();
			}
		}

		public void SetLetterButtonAsWrongGuess(string letter) {
			System.Windows.Forms.Button button = GetLetterButton(letter);
			button.BackColor = System.Drawing.Color.Red;
			button.Enabled = false;
		}

		public void SetLetterButtonAsCorrectGuess(string letter) {
			System.Windows.Forms.Button button = GetLetterButton(letter);
			button.BackColor = System.Drawing.Color.Green;
			button.Enabled = false;
		}

		public void ResetLetterButtons() {
			foreach( var button in lettersButtons ) {
				button.BackColor = SystemColors.Control;
				button.Enabled = true;
			}
		}

		public void DisableAllButtons() {
			foreach (var button in lettersButtons) {
				button.Enabled = false;
			}
		}

		public void SetStage( int position ) {
			pictureBox1.Image = images[position];
			pictureBox1.Refresh();
			pictureBox1.Visible = true;
		}

		private System.Windows.Forms.Button GetLetterButton( string letter ) {
			char l = letter.ToUpper()[0];
			int index = (int)l - 65;
			return lettersButtons[index];
		}

		public bool NextButtonEnabled {
			set => nextWordButton.Enabled = value;
		}

		public void SetProgressCorrect( int position ) {
			System.Windows.Forms.RichTextBox box = progressBoxes[position];
			box.Visible = true;
			box.Text = "O";
			box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
		}

		public void SetProgressWrong(int position) {
			System.Windows.Forms.RichTextBox box = progressBoxes[position];
			box.Visible = true;
			box.Text = "X";
			box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
		}

		private void letterButton_Click(object sender, EventArgs e) {
			System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

			OnLetterButton?.Invoke(button.Text);
		}

		private void nextWordButton_Click(object sender, EventArgs e) {
			OnNextWordButton?.Invoke();
		}
	}
}
