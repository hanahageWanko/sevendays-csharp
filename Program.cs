using System;

namespace sevendays_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("整数値を入力");
      int a = int.Parse(Console.ReadLine());
      // int.Parse()は()内の文字列を整数の値に変換する役割を持つ
      Console.WriteLine("a=" + a);
      if (a > 0)
      {
        Console.WriteLine("aは正の数です");
      }
      else
      {
        Console.WriteLine("aは整数じゃありません");
      }
    }
  }
}
