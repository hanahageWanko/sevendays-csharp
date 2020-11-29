using System;
using System.Text;

namespace sevendays_csharp
{


  class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person();
      p1.Name = "tetteteeteet";
      p1.Age = 11;
      Console.WriteLine("名前：{0}　年齢:{1}", p1.Name, p1.Age);
      // p1.SetNameAndAge("母母", 33, 22222222); 
      p1.allShow(); 
    }

  }
  class Person {
    private string name = "";
    private int age = 0;

    private int telephone = 0;
    public void ShowNameAndAge() {
      Console.WriteLine("名前：{0} 年齢：{1}", name , age);
    }
    public void allShow() {
     Console.WriteLine("名前：{0} 年齢：{1} 電話番号：{2}", name , age, telephone); 
    }
    public void SetNameAndAge(string name , int age) {
      this.name = name;
      this.age = age;
    }
    public void SetNameAndAge(string name , int age , int telephone) {
      this.name = name;
      this.age = age;
      this.telephone = telephone;
    }
    public string Name { set; get; }
    public int Age { set; get; }
  }
}