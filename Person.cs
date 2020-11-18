using System;

namespace sevendays_csharp
{
  class Data
  {
    // Dataオブジェクトの数
    private static int num = 0;
    // データの値
    private int id;
    // 引数つきコンストラクタ
    public Data(int id) {
      this.id = id;
      num++;
      Console.WriteLine("値：{0} 数：{1}", this.id, num);
    }
    // オブジェクトの数を取得
    public static void ShowNumber() {
      Console.WriteLine("Dataオブジェクトの数：{0}", num);
    }
  }
}
