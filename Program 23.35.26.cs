﻿using System;

namespace sevendays_csharp
{
  class Program
  {
      //多次元連想配列
    static void Main(string[] args)
    {
      int[][] a = new int[][] { new int[] { 0, 1 }, new int[] { 2 }, new int[] { 3, 4, 5, 6 } };
      //成分の表示
      for (int m = 0; m < a.Length; m++)
      {
        for (int n = 0; n < a[m].Length; n++)
        {
          Console.Write(a[m][n] + " ");
        }
        Console.WriteLine();

      }

    }
  }
}