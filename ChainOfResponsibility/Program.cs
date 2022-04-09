// See https://aka.ms/new-console-template for more information

using ChainOfResponsibility.Console;

Console.WriteLine("Hello, World!");

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
Client.ExecuteFor(monkey);
Console.WriteLine();


Console.WriteLine("Subchain: Squirrel > Dog\n");
Client.ExecuteFor(squirrel);
Console.WriteLine();

Console.ReadLine();