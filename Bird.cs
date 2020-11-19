using System;

namespace sevendays_csharp
{
  //  スーパークラス
  abstract class Bird
  {
    private string name;
    public Bird(string name)
    {
      this.name = name;
    }
    public string Name{
      get{return name;}
    }
    public abstract void Sing();
  }
}
