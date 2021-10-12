using System;

namespace HelloWord
{
  class Program
  {
    static void Main(string[] args)
    {
      // 정수 = 1, 2, 3, 10, 100 같이 딱 떨어지는 숫자(음수, 0, 양수 모두) -> int
      // byte(1바이트 0~255), short(2바이트 -3만 ~ 3만), int(4바이트 -21억 ~ 21억), long(8바이트) -> 숫자를 나타내는 변수
      // sbyte(1바이트 -128 ~ 127), ushort(2바이트 0 ~ 6만), uint(4바이트 0 ~ 43억), ulong(8바이트)
      // 메모리를 아껴야 하기 때문에 수에 맞는 적당한 변수 선언이 중요하다.
      // id 계열은 long 쓰는것이 마음이 편하다.
      int hp;
      short level = 100;
      hp = 100;
      Console.WriteLine("Hello Number ! {0}", hp);
    }
  }
}
