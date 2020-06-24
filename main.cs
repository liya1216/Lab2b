using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");
    var name = Console.ReadLine();
    Console.WriteLine("Enter sales amount $");
    var S = Console.ReadLine();
    int S1 = Convert.ToInt32(S);
    Console.WriteLine(200 + (0.09 * S1));
    var C = Console.ReadLine();
    int C1 = Convert.ToInt32(C);
    Console.WriteLine("Sales Commission is " +
    C1);
    if (S1 >= 0) 
    {
      Console.WriteLine("Performance is Poor");
    }
    if (S1 >= 3000)
    {
      Console.WriteLine("Performance is Average");
    }
    if (S1 >= 5000) 
    {
      Console.WriteLine("Performance is Good");
    }
    if (S1 >= 10000)
    {
      Console.WriteLine("Performance is Excellent");
    }
    if (S1 >= 15000)
    {
    Console.WriteLine("Performance is Outstanding");
    }
  }
}