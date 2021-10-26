using System;
using System.Collections.Generic;

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

    class Map
    {
      int[,] tiles = {
          {1, 1, 1, 1, 1},
          {1, 0, 0, 0, 1},
          {1, 0, 0, 0, 1},
          {1, 0, 0, 0, 1},
          {1, 1, 1, 1, 1}
        };
      public void Render()
      {
        for (int y = 0; y < tiles.GetLength(1); y++)
        {
          for (int x = 0; x < tiles.GetLength(0); x++)
          {
            if (tiles[y, x] == 1)
              Console.Write("🤒");
            else
              Console.Write("🥶");
          }
          Console.WriteLine();
        }
      }
    }

    class Monster
    {
      public int id;
      public Monster(int id) { this.id = id; }
    }

    public void Arr()
    {
      int[] scores = new int[] { 10, 30, 40, 20, 50 };

      Map map = new Map();
      // map.Render();

      List<int> list = new List<int>();
      for (int i = 0; i < 5; i++)
        list.Add(i);

      // 삽입
      list.Insert(2, 999);
      // 삭제
      list.Remove(3);
      list.RemoveAt(0);
      list.Clear();

      Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
      for (int i = 0; i < 10000; i++)
      {
        dic.Add(i, new Monster(i));
      }

      Monster mon;
      bool found = dic.TryGetValue(500, out mon);

      dic.Remove(7777);
      dic.Clear();

    }
  }
}