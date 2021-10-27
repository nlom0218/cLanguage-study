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
      DelegateGrammer delegateGrammer = new DelegateGrammer();
      EventGrammer eventGrammer = new EventGrammer();
      eventGrammer.Event();
      // dataStructure.Arr();

      while (true)
      {
        // game.Process();

      }
    }
  }
}
