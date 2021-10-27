using System;
namespace HelloWord
{
  class ActGrammer
  {
    class MyList<T>
    {
      T[] arr = new T[10];
      public T GetItem(int i)
      {
        return arr[i];
      }
    }

    static void Test<T>(T input)
    {

    }

    public void Grammer()
    {
      MyList<int> myIntList = new MyList<int>();
      MyList<short> myShortList = new MyList<short>();
      Test<int>(3);
    }
  }
}