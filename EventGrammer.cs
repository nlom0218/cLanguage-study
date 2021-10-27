using System;

namespace HelloWord
{
  class EventGrammer
  {
    static void OnInputTest()
    {
      Console.WriteLine("Input Received!");
    }
    public void Event()
    {
      InputManager inputManager = new InputManager();

      inputManager.InputKey += OnInputTest;

      while (true)
      {
        inputManager.Update();
      }
    }
  }
}