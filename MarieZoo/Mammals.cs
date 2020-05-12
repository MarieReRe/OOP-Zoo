using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public  abstract class Mammals : Animals

{
    public abstract int Age { get; set; }
    public abstract int Weight { get; set; }

    public override string Hunt()
    {
        return "Our mammals have various degrees of hunting ability, keep a safe distance";
    }


}
