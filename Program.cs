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

    // 생성자
    public Knigth()
    {
      hp = 100;
      attack = 10;
      Console.WriteLine("생성자 호출");
    }

    public Knigth(int hp) : this()
    {
      this.hp = hp;
      Console.WriteLine("Int 생성자 호출");
    }

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
    static void Main(string[] args)
    {
      Knigth knigth = new Knigth(50);
    }
  }
}
