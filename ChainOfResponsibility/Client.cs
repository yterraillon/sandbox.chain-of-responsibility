namespace ChainOfResponsibility.Console;
using System;

public class Client
{
     public static void ExecuteFor(AbstractHandler handler)
     {
          var foodList = new List<string> {"Nut", "Banana", "Cup of coffee"};

          foreach (var food in foodList)
          {
               Console.WriteLine($"Client: Who wants a {food}?");

               var result = handler.Handle(food);

               if (result is null)
               {
                    Console.WriteLine("Untouched");
               }
               
               Console.Write($"{result}");
          }
     }
}