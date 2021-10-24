using System;

namespace HelloWord
{
  // 객체 (OOP Object Oriented Programming) => 은닉성, 상속성, 다양성
  // 속성: 데이터로 표현
  // 기능: 함수로 표현

  class Player // 부모클래스 또는 기반클래스
  // 자식클래스에 공통적으로 가지고 있는 인스턴스, 함수를 넣으면 편하다!
  {
    protected int hp;
    protected int attack;
  }

  class Mage : Player // 상속을 받는 자식클래스 또는 파생클래스
  {
    public int mp;
  }

  // 변수를 넘길 때 참조
  class Knigth : Player
  {

  }

  class Program
  {
    static void EnterGame(Player player)
    {
      Mage mage = (player as Mage);
      if (mage != null)
      {
        mage.mp = 10;
      }
    }

    static void Main(string[] args)
    {
      Knigth knigth = new Knigth();
      Mage mage = new Mage();

      EnterGame(knigth);
      EnterGame(mage);
    }
  }
}
