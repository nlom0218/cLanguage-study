using System;

namespace HelloWord
{
  // 객체 (OOP Object Oriented Programming)
  // 속성: 데이터로 표현
  // 기능: 함수로 표현

  // 변수를 넘길 때 참조
  class Knigth
  {
    // public은 다른 클래스에서도 사용할 수 있도록 해준다. 
    public int hp;

    public int attack;

    public Knigth Clone()
    {
      Knigth knigth = new Knigth();
      knigth.hp = hp;
      knigth.attack = attack;
      return knigth;
    }

    public void Move()
    {
      Console.WriteLine("Knight Move");
    }

    public void Attack()
    {
      Console.WriteLine("Knight Attack ");
    }
  }

  // 변수를 넘길 떼 복사
  struct Mage
  {
    public int hp;
    public int attack;
  }

  class Program
  {
    static void KillMage(Mage mage)
    {
      mage.hp = 0;
    }
    static void KillKnight(Knigth knigth)
    {
      knigth.hp = 0;
    }
    static void Main(string[] args)
    {
      Mage mage;
      mage.hp = 100;
      mage.attack = 50;

      Mage mage2 = mage;
      mage2.hp = 0;

      Knigth knigth = new Knigth();
      knigth.hp = 100;
      knigth.attack = 10;

      Knigth knigth2 = knigth.Clone();
      knigth2.hp = 0;

    }
  }
}
