using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Models
{
  public class WordScore
  {
    private string _word;
    private int _score;
    private Dictionary<char, int> scrabDictionary = new Dictionary<char, int>() {{'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K', 5}, {'J', 8}, {'X', 8}, {'Q', 10}, {'Z', 10}, {'_', 0}};

    public WordScore(string word)
    {
      _word = word;
      _score = 0;
    }

    public string GetWord()
    {
      return _word;
    }

    public int GetScore()
    {
      return _score;
    }

    public void ScoreWord()
    {
      string upperWord = _word.ToUpper();
      Console.WriteLine("hey what's up");
      foreach (char letter in upperWord)
      {
        _score += scrabDictionary[letter];
        Console.WriteLine(_score);
      }
    }
  }
}
