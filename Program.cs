using System;

namespace HelloWord
{
  class Program
  {
    static void Main(string[] args)
    {
      Player player = new Knight();
      Player player2 = new Archer();
      Monster monster = new Orc();

      int damage = player.GetAttack();
      monster.OnDamaged(damage);
      player2.OnDamaged(damage);
    }
  }
}
