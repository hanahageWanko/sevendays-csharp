using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("配列の長さを入力してください");
      int x = int.Parse(Console.ReadLine());
      int[] arr = new int[x];
      for(int i = 0; i < x; i++) {
        Console.Write("整数の値{0}:", i);
        arr[i] = int.Parse(Console.ReadLine());
      }
        Console.WriteLine(Max(arr));
        Console.WriteLine(Min(arr));
        Console.WriteLine(Average(arr));
    }
    static int Max(int[] a) {
      int max = int.MinValue;
      for(int i = 0; i < a.Length ; i++) {
        if(max < a[i]) max = a[i];
      }
      return max;
    }
    static int Min(int[] a){
      int min = int.MaxValue;
      for(int i = 0; i < a.Length ; i++) {
        if(min > a[i]) min = a[i];
      }
      return min;
    }
    static double Average(int[] a){
      int ave = 0;
      for(int i = 0; i < a.Length ; i++) {
        ave += a[i];
      }
      return ave / a.Length;
    }

  }
}