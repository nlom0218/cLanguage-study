using System;

namespace HelloWord
{
  class ExceptionGrammer
  {
    class TestException : Exception
    {

    }

    public void Exception()
    {
      try
      {
        // 1. 0으로 나눌 때
        // 2. 잘못된 메모리 참조 (null)
        // 3. 오버플로우
        int a = 10;
        int b = 0;
        int result = a / b;
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine(e);
        throw;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
      finally
      {

      }
    }
  }
}