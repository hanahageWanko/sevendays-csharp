using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      int i1 = 10;
      int i2 = 4;
      short s1 = 10;
      short s2 = 4;
      long l1 = 10;
      long l2 = 4;
      Console.WriteLine(i1 / i2);
      Console.WriteLine(s1 / s2);
      Console.WriteLine(l1 / l2);
      Console.WriteLine((double)i1 / (double)i2);
      Console.WriteLine((double)s1 / (double)s2);
      Console.WriteLine((double)l1 / (double)l2);
    }
  }
}