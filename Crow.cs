using System;

namespace sevendays_csharp
{
  //  スーパークラス
  class Crow : Bird
  {
    public Crow() : base("カラス"){}
    public override void Sing()
    {
      Console.WriteLine("カーカー");
    }

  }
}
