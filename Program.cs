using System;

namespace sevendays_csharp
{
  class Program
  {
    //多次元連想配列
    static void Main(string[] args)
    {
      Person p1, p2;
      p1 = new Person("佐野ひなこ", 23);
      p2 = new Person();
      p2.Name = "ばなな";
      p2.Age = 67;
      p1.ShowAgeAndName();
      p2.ShowAgeAndName();
    }
  }
}
