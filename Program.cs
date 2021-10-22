using System;

namespace HelloWord
{
  // 객체 (OOP Object Oriented Programming)
  // 속성: 데이터로 표현
  // 기능: 함수로 표현

  class Knigth
  {
    // public은 다른 클래스에서도 사용할 수 있도록 해준다. 
    public int hp;

    public int attack;

    public void Move()
    {
      Console.WriteLine("Knight Move");
    }

    public void Attack()
    {
      Console.WriteLine("Knight Attack ");
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      Knigth knigth = new Knigth();
      knigth.hp = 100;
      knigth.attack = 10;

      Console.WriteLine(knigth.hp);
      knigth.Move();
      knigth.Attack();
    }
  }
}
