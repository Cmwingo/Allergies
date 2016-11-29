using System.Collections.Generic;
using System;

namespace Allergy
{
  public class AllergyChecker
  {
    private Dictionary<string, int> _allergyScores = new Dictionary<string, int>() {{"cats", 128}, {"pollen", 64}, {"chocolate", 32}, {"tomatoes", 16}, {"strawberries", 8}, {"shellfish", 4}, {"peanuts", 2}, {"eggs", 1}};

    private int _userScore;
    private List<string> _userAllergies = new List<string>();

    public AllergyChecker(int userScore)
    {
      _userScore = userScore;
    }

    public List<string> Allergies()
    {
      foreach(var pair in _allergyScores)
      {
        Console.WriteLine(pair.Key);
        Console.WriteLine(pair.Value);
        if(_userScore >= pair.Value)
        {
          _userScore -= pair.Value;
          _userAllergies.Add(pair.Key);
          Console.WriteLine("Adding" + pair.Key);
        }
      }
      return _userAllergies;
    }
  }
}
