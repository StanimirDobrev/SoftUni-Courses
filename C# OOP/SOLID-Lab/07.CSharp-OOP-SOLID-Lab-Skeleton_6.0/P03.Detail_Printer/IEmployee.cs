﻿namespace P03.DetailPrinter;

public interface IEmployee
{
    public string Name { get; set; }

    string GetType();
}