﻿namespace ChainOfResponsibility.Console;

public abstract class AbstractHandler : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object? Handle(object request) => _nextHandler?.Handle(request) ?? null;
}