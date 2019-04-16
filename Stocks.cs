using System;
using System.Collections.Generic;

namespace dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> stocks = new Dictionary<string, string>()
            {
                { "GM", "General Motors" },
                { "GE", "General Electric" },
                { "CAT", "Caterpillar" },
                { "AAPL", "Apple" },
                { "MSFT", "Microsoft" },
            };


      List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();


      purchases.Add(new Dictionary<string, double>() { { "GE", 230.21 } });
      purchases.Add(new Dictionary<string, double>() { { "GE", 580.98 } });
      purchases.Add(new Dictionary<string, double>() { { "GE", 406.34 } });
      purchases.Add(new Dictionary<string, double>() { { "AAPL", 1000006.34 } });


      foreach (Dictionary<string, double> purchase in purchases)
      {
        foreach (KeyValuePair<string, double> transaction in purchase)
        {
          Console.WriteLine(transaction);

          string fullCompanyName = stocks[transaction.Key]; //AAPL
          Console.WriteLine(fullCompanyName + " " + transaction.Value);

        }
      }
    }
  }
}