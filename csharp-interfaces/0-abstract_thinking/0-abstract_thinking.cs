using System;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        Type type = this.GetType();

        return ($"{name} is a {type}");
    }
}
