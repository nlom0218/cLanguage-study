using System;

namespace HelloWord
{
  class Program
  {
    static void Main(string[] args)
    {
      //   int hp;
      //   hp = 100;
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

      //   // 형식 병환
      //   // 1. 바구니 크기가 다른 경우
      //   int a = 1000;
      //   short b = (short)a;

      //   // 2. 바구니 크기는 같은 한데, 부호가 다를 경우
      //   byte c = 255;
      //   sbyte sb = (sbyte)c;
      //   // 0xFF = 0b11111111 = -1

      //   // 3. 소수
      //   float f = 3.1313f;
      //   double d = f;

      //   int hp = 100;
      //   //   hp = 100 % 3; 
      //   //   hp++; // = hp + 1
      //   //   hp--; // = hp - 1
      //   Console.WriteLine(hp++);

      //   bool b = (hp == 101);
      //   Console.WriteLine(b);

      //   bool isAlive = (hp > 0);
      //   int level = 50;
      //   bool isHighLevel = (level >= 40);

      //   // && => AND
      //   // || => OR
      //   // ! => NOT

      //   // a = 살아있는 고렙 유저인가요?
      //   bool a = isAlive && isHighLevel;

      //   // bb = 살아있거나, 고렙 유저이거나, 둘 중 하나인가요?
      //   bool bb = isAlive || isHighLevel;

      //   // c = 죽은 유저인가요?
      //   bool c = !isAlive;

      // 비트 연산
      // << >> &(and) |(or) ^(xor) ~(not)
      //   int num = 1;
      //   num = num << 3;
      //   num = 22 | 45;
      //   Console.WriteLine(num);

      // int a;
      // a = 100;
      // a = a + 1;
      // a += 1;
      // a = a - 1;
      // a -= 1;
      // a = a * 1;
      // a *= 1;
      // a = a / 1;
      // a /= 1;
      // a = a & 1;
      // a &= 1;
      // a = 1;
      // a = a << 1;
      // a <<= 1;
      // a = a >> 1;
      // a >>= 1;
      // a = a & 1;
      // a &= 1;
      // a = a | 1;
      // a |= 1;
      // Console.WriteLine(a);

      // 연산 우선 순위
      // 1. ++ --
      // 2. * / %
      // 3. + -
      // 4. << >>
      // 5. < >
      // 6. == !=
      // 7. &
      // 8. ^
      // 9. |
      // ...
      // 외워서 하는 것 보다 가로의 중첩을 이용하여 우선 순위를 만들자.
      // int hp = 10;
      // bool isDead = (hp <= 0);

      // if (isDead)
      // {
      //   Console.WriteLine("You are dead!");
      // }
      // else
      // {
      //   Console.WriteLine("You are alive");
      // }
      int choice = 2; // 0:가위 1:바위 2:보

      if (choice == 0)
      {
        Console.WriteLine("가위입니다.");
      }
      else if (choice == 1)
      {
        Console.WriteLine("바위입니다.");
      }
      else
      {
        Console.WriteLine("보입니다.");
      }
    }
  }
}
