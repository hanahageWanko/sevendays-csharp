using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("身長");
      double height = double.Parse(Console.ReadLine()) * 0.01;
      Console.WriteLine("体重");
      double weight = double.Parse(Console.ReadLine());

      double BMI = weight / (height * height);
      Console.WriteLine("体重：{0}", weight);
      Console.WriteLine("身長：{0}", height);
      Console.WriteLine("BMI：{0}", BMI);
      string result = "" ?? "測定不能";
      if (BMI < 19.8)
      {
        result = "やせ型";
      }
      else if (19.8 <= BMI && BMI < 24.2)
      {
        result = "普通";
      }
      else if (24.2 <= BMI && BMI < 26.4)
      {
        result = "やや肥満（過体重)";
      }
      else if (26.4 <= BMI && BMI < 35.0)
      {
        result = "肥満";
      }
      else
      {
        result = "肥満";
      }
      Console.WriteLine("結果：" + result);
    }
  }
}