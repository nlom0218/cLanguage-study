using System;

namespace HelloWord
{
  class Program
  {
    enum Choice
    {
      Rock = 1,
      Paper = 2,
      Scissors = 0
    }

    // Method Function
    static void HellowWorld()
    {
      Console.WriteLine("Hello World");
    }

    static void AddOne(ref int number)
    {
      number++;
    }

    static int AddOne2(int number)
    {
      return number + 1;
    }

    static void Swap(ref int a, ref int b)
    {
      int temp = a;
      a = b;
      b = temp;
    }

    static void Divide(int a, int b, out int result1, out int result2)
    {
      result1 = a / b;
      result2 = a % b;
    }

    static void Print(int value)
    {
      System.Console.WriteLine(value);
    }

    // overloading => 함수 이름의 재사용
    static int AddFn(int a, int b)
    {
      // Console.WriteLine("Add int 호출");
      Print(a + b);
      return (a + b);
    }

    // static float AddFn(float a, float b)
    // {
    //   Console.WriteLine("Add float 호출");
    //   return (a + b);
    // }

    // static int AddFn(int a, int b, int c)
    // {
    //   Console.WriteLine("Add int 호출");
    //   return a + b + c;
    // }

    static int Factorial(int n)
    {
      // int result = 1;
      // for (int i = 0; i < n; i++)
      // {
      //   result *= (i + 1);
      // }
      // return result;
      if (n <= 1)
        return 1;
      return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
      Program.AddFn(5, 5);
      Program.AddFn(5, 10);
      Program.AddFn(10, 15);
      Program.AddFn(15, 15);
      Program.AddFn(10, 20);
      // System.Console.WriteLine(ret);
      // int ret = Factorial(5);
      // System.Console.WriteLine(ret);
      // for (int i = 0; i < 9; i++)
      // {
      //   for (int z = 0; z < 9; z++)
      //   {
      //     Console.WriteLine($"{i + 1} * {z + 1} = {(i + 1) * (z + 1)}");
      //   }
      // }
      // string star = "*";
      // for (int i = 0; i < 5; i++)
      // {
      //   System.Console.WriteLine(star);
      //   star = star + "*";
      // }

      // for (int i = 0; i < 5; i++)
      // {
      //   for (int j = 0; j < i + 1; j++)
      //   {
      //     System.Console.Write("*");
      //   }
      //   System.Console.WriteLine();
      // }
      // int ret = Program.AddFn(2, 3);
      // float ret2 = Program.AddFn(2.0f, 3.0f);
      // int ret3 = Program.AddFn(2, 3, 4);
      // Console.WriteLine(ret);
      // Console.WriteLine(ret2);
      // Console.WriteLine(ret3);
      // int result = Program.AddFn(34, 512);
      // int a = 0;
      // Program.AddOne(ref a);
      // Console.WriteLine(a);

      // a = Program.AddOne2(a);
      // Console.WriteLine(a);
      // int num1 = 1;
      // int num2 = 2;
      // Program.Swap(ref num1, ref num2);
      // Console.WriteLine(num1);
      // Console.WriteLine(num2);
      // int num1 = 10;
      // int num2 = 3;

      // int result1;
      // int result2;
      // Divide(num1, num2, out result1, out result2);
      // Console.WriteLine(result1);
      // Console.WriteLine(result2);

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
      // int choice = 2; // 0:가위 1:바위 2:보 3:치트키 

      // if (choice == 0)
      // {
      //   Console.WriteLine("가위입니다.");
      // }
      // else if (choice == 1)
      // {
      //   Console.WriteLine("바위입니다.");
      // }
      // else
      // {
      //   Console.WriteLine("보입니다.");
      // }

      // switch case break 3종 세트이다. 
      // 값는 정수 또는 문자열이다.
      // if문이 응용 범위가 더 많다.
      // switch (choice)
      // {
      //   case 0:
      //     Console.WriteLine("가위입니다.");
      //     break;
      //   case 1:
      //     Console.WriteLine("바위입니다.");
      //     break;
      //   case 2:
      //     Console.WriteLine("보입니다.");
      //     break;
      //   case 3:
      //     Console.WriteLine("치트키입니다.");
      //     break;
      //   default:
      //     // default는 if / else 문에서 else에 해당된다. 즉, 모든 조건에 만족하지 않는다면 밑의 로직이 실행
      //     Console.WriteLine("다 실패했습니다.");
      //     break;
      // }

      // 삼항연산자
      // int number = 24;
      // bool isPair = (number % 2 == 0 ? true : false); // true: 짝수, false: 홀수
      // Console.WriteLine(isPair);

      // 가위바위보 게임
      // 0: 가위, 1: 바위, 2:보

      // Random rand = new Random();
      // int aiChoice = rand.Next(0, 3); // 0~2사이의 랜덤 값

      // int choice = Convert.ToInt32(Console.ReadLine());

      // switch (choice)
      // {
      //   case (int)Choice.Scissors:
      //     Console.WriteLine("당신의 선택은 가위입니다.");
      //     break;
      //   case (int)Choice.Rock:
      //     Console.WriteLine("당신의 선택은 바위입니다.");
      //     break;
      //   case (int)Choice.Paper:
      //     Console.WriteLine("당신의 선택은 보입니다.");
      //     break;
      // }

      // switch (aiChoice)
      // {
      //   case (int)Choice.Scissors:
      //     Console.WriteLine("컴퓨터의 선택은 가위입니다.");
      //     break;
      //   case (int)Choice.Rock:
      //     Console.WriteLine("컴퓨터의 선택은 바위입니다.");
      //     break;
      //   case (int)Choice.Paper:
      //     Console.WriteLine("컴퓨터의 선택은 보입니다.");
      //     break;
      // }

      // // 승리, 패패, 무승부
      // switch (choice)
      // {
      //   case (int)Choice.Scissors:
      //     if (aiChoice == (int)Choice.Scissors)
      //     {
      //       Console.WriteLine("무승부입니다.");
      //     }
      //     else if (aiChoice == (int)Choice.Rock)
      //     {
      //       Console.WriteLine("패패했습니다.");
      //     }
      //     else
      //     {
      //       Console.WriteLine("승리했습니다.");
      //     }
      //     break;
      //   case (int)Choice.Rock: // 바위
      //     if (aiChoice == (int)Choice.Scissors) // 가위
      //     {
      //       Console.WriteLine("승리했습니다.");
      //     }
      //     else if (aiChoice == (int)Choice.Rock) // 바위
      //     {
      //       Console.WriteLine("무승부입니다.");
      //     }
      //     else // 보
      //     {
      //       Console.WriteLine("패패했습니다.");
      //     }
      //     break;
      //   case (int)Choice.Paper: // 내가 보
      //     if (aiChoice == (int)Choice.Scissors) // 가위
      //     {
      //       Console.WriteLine("패패했습니다.");
      //     }
      //     else if (aiChoice == (int)Choice.Rock) // 바위
      //     {
      //       Console.WriteLine("승리했습니다.");
      //     }
      //     else // 보
      //     {
      //       Console.WriteLine("무승부입니다.");
      //     }
      //     break;
      // }

      // while 반복문 & for 반복문

      // int count = 0;
      // while (count < 5)
      // {
      //   Console.WriteLine("Hello World");
      //   count++;
      // }

      // string answer;
      // do
      // {
      //   Console.WriteLine("강사님은 잘생기셨나요?(y/n): ");
      //   answer = Console.ReadLine();
      // } while (answer != "y");
      // Console.WriteLine("정답입니다!");

      // for (int i = 0; i < 5; i++)
      // {
      //   Console.WriteLine("Hello World");
      // }

      // break
      // int num = 97;
      // bool isPrime = true;
      // for (int i = 2; i < num; i++)
      // {
      //   if (num % i == 0)
      //   {
      //     isPrime = false;
      //     break;
      //   }
      // }
      // if (isPrime)
      // {
      //   Console.WriteLine("소수입니다.");
      // }
      // else
      // {
      //   Console.WriteLine("소수가 아닙니다.");
      // }

      // for (int i = 1; i < 101; i++)
      // {
      //   if (i % 3 != 0)
      //     continue;

      //   Console.WriteLine($"3으로 나뉘는 숫자 발견: {i}");

      // }

      // function
    }
  }
}
