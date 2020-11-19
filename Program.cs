using System;

namespace sevendays_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Dummy d  =new Dummy();
      IFunc1 i1 = (IFunc1)d;
      IFunc2 i2 = (IFunc2)d;
      i1.Func1();
      i1.Func2();
      i2.Func2();
      i2.Func3();
    }
  }
}
