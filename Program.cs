using System;

namespace sevendays_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      {
        Parent p = new Parent();
        Child c = new Child();
        p.Foo();
        c.Foo();
      };
    }
  }
}
