namespace ChainOfResponsibility.Console;

public class MonkeyHandler : AbstractHandler
{
    public override object? Handle(object request) => 
        request as string == "Banana" 
            ? $"Monkey: I'll eat the {request}.\n" 
            : base.Handle(request);
}

public class SquirrelHandler  : AbstractHandler
{
    public override object? Handle(object request) => 
        request as string == "Nut" 
            ? $"Squirrel: I'll eat the {request}.\n" 
            : base.Handle(request);
}

public class DogHandler  : AbstractHandler
{
    public override object? Handle(object request) => 
        request as string == "Meat" 
            ? $"Dog: I'll eat the {request}.\n" 
            : base.Handle(request);
}