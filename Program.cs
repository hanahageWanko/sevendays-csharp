using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Animal m = new Animal("お猿さん", "Monkey", 1);
      ISing s = (ISing)m;
      s.Sing("キーキー！");
      IName n = (IName) m;
      n.Naming("ジョージ");

    }
  }
}