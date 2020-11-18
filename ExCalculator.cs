using System;

namespace sevendays_csharp
{
  class ExCalculator : Calculator
  {

    public void mul()
    {
      Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
    }
    public void div() 
    {
      Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
    }

  }
}
