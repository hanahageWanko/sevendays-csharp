using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Bird b  = new Bird(1, "カラーす", "カラス");
      b.showData();
      Bird.showStaticData();

    }

  }
  class Bird {
    private int id = 0;
    private static int num = 0;
    private string name = "";
    private string type = "";

    public Bird(int id, string name, string type ) {
      this.id = id;
      num++;
      this.name = name;
      this.type = type;
    }
    public string Name{set;get;}
    public string Type{set;get;}

    public void showData() {
      Console.WriteLine("ID：{0} 名前：{1} 種類：{2}", id,name,type);
    }
    public static void showStaticData() {
     Console.WriteLine("鳥の登録数：{0}", num); 
    }

  }
}