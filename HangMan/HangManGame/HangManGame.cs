using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMG {
    public class HangManGame {

		private string[] allWords = new string[] {
			"paraphilia",
			"frotteurism",
			"sadism",
			"fetishism",
			"voyeurism",
			"masochism",
			"exibitionism",
		};

		public int CurrentWordIndex { get; private set; }

		public string CurrentWordShown { get; private set; }

		public string CurrentWord {
			get {
				// TODO check that the index is within the bounds
				return allWords[CurrentWordIndex];
			}
		}

		public bool WordCompleted {
			get {
				return !CurrentWordShown.Contains("_");
			}
		}

		public int WrongGuesses;

		public bool HasNext {
			get => CurrentWordIndex != allWords.Length-1;
		}

		public HangManGame() {
			CurrentWordIndex = 0;
			ResetShownWord();
			WrongGuesses = 0;
		}


		private void ResetShownWord() {
			CurrentWordShown = "";
			for ( int i = 0; i < CurrentWord.Length; i ++ ) {
				CurrentWordShown += "_";
			}
			
		}
		public bool GuessLetter( string letter ) {
			char l = letter.ToLower()[0];
			string shown = "";
			for ( int i = 0; i < CurrentWord.Length; i ++ ) {
				char c = CurrentWord[i];
				if ( c == l ) {
					shown += l;
				} else {
					shown += CurrentWordShown[i];
				}
			}
			CurrentWordShown = shown;
			bool result = CurrentWord.Contains(letter.ToLower());
			if ( !result ) {
				WrongGuesses++;
			}
			return result;
		}

		public void NextWord() {
			// TODO check that the index is within the bounds
			CurrentWordIndex += 1;
			if (CurrentWordIndex == allWords.Length) {
				CurrentWordIndex = 0;
			}

			ResetShownWord();
			WrongGuesses = 0;
		}
    }
}
