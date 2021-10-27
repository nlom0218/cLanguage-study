using System;

namespace HelloWord
{
  class DelegateGrammer
  {
    delegate int OnClicked();
    // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
    // 반환: int 입력: void
    // OnClikced 이 delegate 형식의 이름

    static void ButtonPressed(OnClicked clickedFunction)
    {
      clickedFunction();
    }

    static int TestDelegate()
    {
      Console.WriteLine("Hello Delegate");
      return 0;
    }
    static int TestDelegate2()
    {
      Console.WriteLine("Hello Delegate 2");
      return 0;
    }

    public void Delegate()
    {
      // delegate (대리자) 별표 다섯개
      OnClicked clicked = new OnClicked(TestDelegate);
      clicked += TestDelegate2;

      ButtonPressed(clicked);
    }
  }
}