using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HMG;

namespace GameTests {
	[TestClass]
	public class GameTests {
		[TestMethod]
		public void TestMethod1() {
			HangManGame game = new HangManGame();

			Assert.IsTrue(game.CurrentWord.Equals("sadism"));

			Assert.IsTrue(game.GuessLetter("A"));
			Assert.IsFalse(game.GuessLetter("Z"));
		}

		[TestMethod]
		public void TestMethod2() {
			HangManGame game = new HangManGame();

			Assert.IsTrue(game.CurrentWord.Equals("sadism"));

			game.NextWord();

			Assert.IsTrue(game.CurrentWord.Equals("masochism"));

			Assert.IsTrue(game.GuessLetter("S"));
			Assert.IsFalse(game.GuessLetter("j"));
		}

		[TestMethod]
		public void TestMethod3() {
			HangManGame game = new HangManGame();

			Assert.IsTrue(game.CurrentWord.Equals("sadism"));
			Assert.IsTrue(game.CurrentWordShown.Equals("______"));

			Assert.IsTrue(game.GuessLetter("S"));
			Assert.IsTrue(game.CurrentWordShown.Equals("s___s_"));

			Assert.IsTrue(game.GuessLetter("d"));
			Assert.IsTrue(game.CurrentWordShown.Equals("s_d_s_"));

			Assert.IsTrue(game.GuessLetter("A"));
			Assert.IsTrue(game.CurrentWordShown.Equals("sad_s_"));
			Assert.IsTrue(game.CurrentWordShown.ToUpper().Equals("SAD_S_"));

			Assert.IsTrue(game.GuessLetter("m"));
			Assert.IsTrue(game.CurrentWordShown.Equals("sad_sm"));

			Assert.IsTrue(game.GuessLetter("i"));
			Assert.IsTrue(game.CurrentWordShown.Equals("sadism"));

			game.NextWord();

			Assert.IsTrue(game.CurrentWord.Equals("masochism"));
			Assert.IsTrue(game.CurrentWordShown.Equals("_________"));
		}

		[TestMethod]
		public void TestMethod4() {

			char a = 'A';

			Assert.IsTrue((int)a == 65);
		}
	}
}
