using System;

namespace HelloWord
{
  class PropertyGrammer
  {

    // 객체지향 -> 은닉성
    class Knight
    {

      public int Hp { get; set; }
      void Test()
      {
        Hp = 100;
      }
    }

    public void Property()
    {
      Knight knight = new Knight();
      knight.Hp = 100;
      int hp = knight.Hp;
    }
  }
}