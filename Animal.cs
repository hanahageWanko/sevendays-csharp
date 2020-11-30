using System;
using System.Text;

namespace sevendays_csharp
{
  class Animal : ISing, IName
  {
    private string name = "";

    private string type = "";

    private int id = 0;

    private static int num = 0;
    public Animal(string name, string type, int id)
    {
      this.name = name;
      this.type = type;
      this.id = id;
      num++;
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
    public int Id
    {
      set { id = value; }
      get { return id; }
    }

    public void Sing(string sing)
    {
      Console.WriteLine(sing + "の泣き声の主は" + this.type + "です");
    }

    public void Naming(string name)
    {
      Console.WriteLine(name + "はとても可愛らしい" + this.type + "です");
    }
  }

}