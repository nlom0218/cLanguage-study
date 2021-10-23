using System;

namespace HelloWord
{
  // 객체 (OOP Object Oriented Programming) => 은닉성, 상속성, 다양성
  // 속성: 데이터로 표현
  // 기능: 함수로 표현

  class Player // 부모클래스 또는 기반클래스
  // 자식클래스에 공통적으로 가지고 있는 인스턴스, 함수를 넣으면 편하다!
  {
    static public int count = 1; // 오로지 한개만 존재
    public int id;
    public int hp;
    public int attack;

    public Player()
    {
      Console.WriteLine("Player 생성자 호출!");
    }

    public Player(int hp)
    {
      this.hp = hp;
      Console.WriteLine("player hp 생성자 호출!");
    }
    public void Move()
    {
      Console.WriteLine("Knight Player");
    }

    public void Attack()
    {
      Console.WriteLine("Knight Player ");
    }
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


  }

  class Program
  {
    static void Main(string[] args)
    {
      Knigth knigth = new Knigth();
      Mage mage = new Mage();

    }
  }
}
