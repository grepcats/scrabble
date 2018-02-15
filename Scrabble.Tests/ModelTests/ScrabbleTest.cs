using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordScoreTest
  {
    [TestMethod]
    public void GetWord_TestInput_String()
    {

      //Arrange
      string controlWord = "banana";
      int controlScore = 8;
      WordScore newWordScore = new WordScore("banana");
      newWordScore.ScoreWord();

      //Act
      string wordResult = newWordScore.GetWord();
      int scoreResult = newWordScore.GetScore();


      //Assert
      Assert.AreEqual(wordResult, controlWord);
      Assert.AreEqual(scoreResult, controlScore);
    }

    [TestMethod]
    public void ScoreWord_TestOutput_Void()
    {
      //arrange
      int controlScore = 8;
      WordScore newWordScore = new WordScore("banana");

      //act
      newWordScore.ScoreWord();

      //assert
      Assert.AreEqual(controlScore, newWordScore.GetScore());
    }

    [TestMethod]
    public void ScoreWord_TestCaps_Void()
    {
      //arrange
      int controlScore = 8;
      WordScore newWordScore = new WordScore("BAnAna");

      //act
      newWordScore.ScoreWord();

      //assert
      Assert.AreEqual(controlScore, newWordScore.GetScore());
    }
  }
}
