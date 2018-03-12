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
		public MainWindow() {
			InitializeComponent();
			InitializeLetterButtons();
		}

		private void letterButton_Click(object sender, EventArgs e) {
			System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;


		}
	}
}
