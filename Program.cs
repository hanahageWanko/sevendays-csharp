using System;

namespace sevendays_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Crow c = new Crow();
      Sparrow s = new Sparrow();
      Console.WriteLine(c.Name + " : ");
      c.Sing();
      Console.WriteLine(s.Name + " : ");
      s.Sing();
    }
  }
}
