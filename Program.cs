using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Bird b = new Bird(1, "カラーす", "カラス");
      b.mind();
      b.showData();
      Bird.showStaticData();
      Fry c = new Fry(4, 2);
      c.Id = 1;
      c.Name = "雀-me";
      c.Type = "雀";
      c.mind();
      c.showFlapping();
      c.showData();
    }

  }
  class Bird
  {
    private int id = 0;
    private static int num = 0;
    private string name = "";
    private string type = "";

    public Bird()
    {
      Console.WriteLine("鳥の個性について表す。");
    }

    public Bird(int id, string name, string type)
    {
      this.id = id;
      num++;
      this.name = name;
      this.type = type;
    }
    public int Id
    {
      set { id = value; }
      get { return id; }
    }
    public string Name
    {
      set { name = value; }
      get { return name; }
    }
    public string Type
    {
      set { type = value; }
      get { return type; }
    }

    public void showData()
    {
      Console.WriteLine("ID：{0} 名前：{1} 種類：{2}", id, name, type);
    }
    public static void showStaticData()
    {
      Console.WriteLine("鳥の登録数：{0}", num);
    }
    public virtual void mind()
    {
      Console.WriteLine("鳥の種類が知りたいぜ〜");
    }

  }
  class Fry : Bird
  {
    private int flapping = 0;
    private int wings = 0;

    public Fry(int flapping, int wings)
    {
      this.flapping = flapping;
      this.wings = wings;
    }

    public void showFlapping()
    {
      Console.WriteLine("羽の枚数は{0}で羽ばたきは{1}回", wings, flapping);
    }

    public override void mind()
    {
      Console.WriteLine("鳥の個性が知りたいぜ〜");
    }

  }
}