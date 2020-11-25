using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("配列の長さを指定してください");
      int n = int.Parse(Console.ReadLine());
      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
        Console.Write("要素{0}:", i);
        int x = int.Parse(Console.ReadLine());
        arr[i] = x;
      }

      int max = arr[0];
      int min = arr[0];
      for (int v = 0; v < arr.Length; v++)
      {
        max = max < arr[v] ? arr[v] : max;
        min = min > arr[v] ? arr[v] : min;
      }


      Console.WriteLine("MAX：{0}", max);
      Console.WriteLine("MIN：{0}", min);
      Console.WriteLine("AVERAGE：{0}", (max + min) / 2);
    }
  }
}