using System;
using System.Collections.Generic;

namespace Allergy
{
  public class AllergyCheckerTest
  {
    public static void Main()
    {
      AllergyChecker personsAllergies = new AllergyChecker(30);
      List<string> allergies = personsAllergies.Allergies();
      foreach(string allergy in allergies)
      {
        Console.WriteLine(allergy);
      }
    }

  }
}
