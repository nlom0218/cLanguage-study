using System;

namespace HelloWord
{

  class DataStructure
  {
    static int GetHighestScore(int[] scores)
    {
      int highestScore = 0;
      foreach (int score in scores)
      {
        if (highestScore < score)
          highestScore = score;
      }
      return highestScore;
    }

    static int GetAverageScore(int[] scores)
    {
      if (scores.Length == 0)
        return 0;

      int totalNum = 0;
      foreach (int score in scores)
      {
        totalNum += score;
      }

      return totalNum / scores.Length;
    }

    static int GetIndexOf(int[] scores, int value)
    {
      int index = Array.IndexOf(scores, value);
      return index;
    }

    static void Sort(int[] scores)
    {
      Array.Sort(scores);
    }
    public void Arr()
    {
      int[] scores = new int[] { 10, 30, 40, 20, 50 };
      int averageScore = GetAverageScore(scores);
      int valueIndex = GetIndexOf(scores, 15);
      int highestScore = GetHighestScore(scores);

    }
  }
}