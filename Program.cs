using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("値1");
      double x = double.Parse(Console.ReadLine());
      Console.WriteLine("値2");
      double y = double.Parse(Console.ReadLine());
      Console.WriteLine("値3");
      double z = double.Parse(Console.ReadLine());
      double max, min;
      double[] arr = new double[] { x, y, z };
      max = arr[0];
      min = arr[0];
      for (int i = 0; i < arr.Length; i++)
      {
        max = max < arr[i] ? arr[i] : max;
        min = min > arr[i] ? arr[i] : min;
      }

      Console.WriteLine("MAX：{0}", max);
      Console.WriteLine("MIN：{0}", min);
    }
  }
}