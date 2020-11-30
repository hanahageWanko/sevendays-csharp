using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Crow c = new Crow();
      Sparrow s = new Sparrow();
      c.Sing();
      s.Sing();
      
    }
    class Crow : Bird
    {
        public Crow() : base("カラス")
        {
        }
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }

    class Sparrow : Bird {
      public Sparrow() : base("雀"){}

      public override void Sing() {
        Console.WriteLine("ちゅんちゅん");
      }

    }

    abstract class Bird {
      private string name = "";
      public Bird(string name) {
        this.name = name;
      }
      public string Name {
        set{name = value;}
        get{return name;}
      }

      public abstract void Sing();
    }

  }

}