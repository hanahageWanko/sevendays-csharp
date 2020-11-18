using System;

namespace sevendays_csharp
{
  class Program
  {
    //多次元連想配列
    static void Main(string[] args)
    {
      //  Dataクラスを3つ作る
      Data [] d = new Data[2];
      Data.ShowNumber();
      for (int i = 0; i < d.Length; i++) {
        d[i] = new Data(i * 100);
        Data.ShowNumber();
      }
    }
  }
}
