using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangManGUI;

namespace HMG {
	class Controller {

		private MainWindow window;
		private HangManGame game;

		public Controller( MainWindow window ) {
			this.window = window;
			game = new HangManGame();

			window.OnLetterButton += OnLetterButton;
			window.OnNextWordButton += OnNextWordButton;

			window.ResetLetterButtons();
			window.ShownWord = game.CurrentWordShown;
		}

		private void OnLetterButton(string letter) {
			if ( game.GuessLetter(letter) ) {
				window.ShownWord = game.CurrentWordShown;
				window.SetLetterButtonAsCorrectGuess(letter);

				if ( game.WordCompleted ) {
					window.DisableAllButtons();
					window.SetProgressCorrect(game.CurrentWordIndex);
				}
			} else {
				window.SetLetterButtonAsWrongGuess(letter);
				window.SetStage(game.WrongGuesses);
				if ( game.WrongGuesses == 3 ) {
					window.DisableAllButtons();
					window.SetProgressWrong(game.CurrentWordIndex);
				}
			}
		}

		private void OnNextWordButton() {
			if ( !game.WordCompleted ) {
				window.SetProgressWrong(game.CurrentWordIndex);
			}
			game.NextWord();
			window.ResetLetterButtons();
			window.ShownWord = game.CurrentWordShown;
			window.SetStage(0);
			window.NextButtonEnabled = game.HasNext;
		}
	}
}
