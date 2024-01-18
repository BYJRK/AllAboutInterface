namespace AllAboutInterface.Basics.StaticMethod;

interface IStaticMethod
{
    static void StaticMethod()
    {
        Console.WriteLine("IStaticMethod.Foo");
    }
}

class DemoClass : IStaticMethod
{
    
}