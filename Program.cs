using System;

namespace HelloWord
{
  // 객체 (OOP Object Oriented Programming) => 은닉성, 상속성, 다양성
  // 속성: 데이터로 표현
  // 기능: 함수로 표현

  class Player // 부모클래스 또는 기반클래스
  // 자식클래스에 공통적으로 가지고 있는 인스턴스, 함수를 넣으면 편하다!
  {

  }

  class Mage : Player // 상속을 받는 자식클래스 또는 파생클래스
  {
  }

  class Archer : Player
  {

  }

  // 변수를 넘길 때 참조
  class Knigth : Player
  {
    private int hp;
    // private : 아무도 접근할 수 없다. 나만 사용할 수 없다.

    public void SetHp(int hp)
    // public : 모두에게 공유
    {
      this.hp = hp;
    }

    protected int mp;
    // protected : 외부에서는 사용할 수 없지만 상속을 받은 자식 클래스에서는 사용할 수 있다. 
  }

  class SuperKnigth : Knigth
  {
    void Test()
    {
      mp = 10;
      hp = 20;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Knigth knigth = new Knigth();
      knigth.SetHp(100);
    }
  }
}
