using System;

namespace HelloWord
{
  class Program
  {
    static void Main(string[] args)
    {
      int hp;
      hp = 100;
      //   // 정수 = 1, 2, 3, 10, 100 같이 딱 떨어지는 숫자(음수, 0, 양수 모두) -> int
      //   // byte(1바이트 0~255), short(2바이트 -3만 ~ 3만), int(4바이트 -21억 ~ 21억), long(8바이트) -> 숫자를 나타내는 변수
      //   // sbyte(1바이트 -128 ~ 127), ushort(2바이트 0 ~ 6만), uint(4바이트 0 ~ 43억), ulong(8바이트)
      //   // 메모리를 아껴야 하기 때문에 수에 맞는 적당한 변수 선언이 중요하다.
      //   // id 계열은 long 쓰는것이 마음이 편하다.

      //   // 10진수

      //   // 2진수 0~1
      //   // 0b00 0b01 0b10 0b11 0b100 0b101 0b110 0b111

      //   // 16진수 0~9 a b c d e f
      //   // 0x00 0x01 0x02 .. 0x0F 0x10 

      //   // 2진수 -> 16진수
      //   // 0b10001111 = 0x8F

      //   bool b;
      //   b = true;
      //   b = false;
      //   // 1바이트를 차지(참/거짓) - 비트보다 바이트를 컴퓨터가 빠르게 처리한다.

      //   float f = 3.14f; // 4바이트
      //   double d = 3.14; // 8바이트
      //   // 소수

      //   char c = 'a'; // 2바이트
      //   string str = "Hellow Number";

      // 형식 병환
      // 1. 바구니 크기가 다른 경우
      int a = 1000;
      short b = (short)a;

      // 2. 바구니 크기는 같은 한데, 부호가 다를 경우
      byte c = 255;
      sbyte sb = (sbyte)c;
      // 0xFF = 0b11111111 = -1

      // 3. 소수
      float f = 3.1313f;
      double d = f;

      Console.WriteLine("Hello Number ! {0}", hp);
    }
  }
}
