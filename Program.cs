using System;

namespace HelloWord
{
  class Program
  {
    static void Main(string[] args)
    {
      Game game = new Game();
      DataStructure dataStructure = new DataStructure();
      ActGrammer actGrammer = new ActGrammer();
      PropertyGrammer propertyGrammer = new PropertyGrammer();
      propertyGrammer.Property();
      // dataStructure.Arr();

      while (true)
      {
        // game.Process();

      }
    }
  }
}
