using System;

namespace sevendays_csharp
{
  class Sparrow : Bird
  {
    public Sparrow() : base("雀"){}
    public override void Sing()
    {
      Console.WriteLine("ちゅんちゅん");
    }
  }

}
