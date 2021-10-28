using System;

namespace HelloWord
{
  class NullableGrammer
  {

    static Monster FindMonster(int id)
    {
      return null;
    }

    static int Find()
    {
      return 0;
    }

    class Monster
    {
      public int id { get; set; }
    }
    public void Nullable()
    {
      Monster monster = FindMonster(101);
      if (monster != null)
      {

      }
      int? number = null;

      int b = number ?? 0;
      Console.WriteLine(b);

      Monster monster1 = null;
      int? id = monster?.id;
    }
  }
}