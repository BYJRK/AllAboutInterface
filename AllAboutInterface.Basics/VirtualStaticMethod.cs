namespace AllAboutInterface.Basics.VirtualStaticMethod;

interface IVirtualStaticMethod
{
    /// <summary>
    /// 一个接口中的静态虚方法（带有默认实现）
    /// </summary>
    static virtual void Foo()
    {
        Console.WriteLine("Foo from interface");
    }
}

interface IFoo : IVirtualStaticMethod
{
    new static void Foo()
    {
        
    }
}

class DemoClass : IVirtualStaticMethod
{
    /// <inheritdoc cref="IVirtualStaticMethod.Foo"/>
    public static void Foo()
    {
        Console.WriteLine("Foo from class");
    }
}

static class Usage
{
    public static void Demo()
    {
        
    }
}