using System;

namespace sevendays_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      CellPhone cp = new CellPhone("hoge@email.com", "090-1234-5688");
      cp.Call("011-123-4567");
      cp.SendMail("fuga@email.com");
      IPhone phone = (IPhone)cp;
      phone.Call("011-9876-2345");
      IEmail mail = (IEmail)cp;
      mail.SendMail("bar@email.com");
    }
  }
}
