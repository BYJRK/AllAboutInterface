namespace AllAboutInterface.Basics.NonPublicMembers;

interface IFooBase
{
    // 接口中的非公开方法必须给出默认实现
    private void PrivateMethod()
    {
        Console.WriteLine("IFooBase.PrivateMethod");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("IFooBase.ProtectedMethod");
    }
    
    void PublicMethod()
    {
        Console.WriteLine("IFooBase.PublicMethod");
        PrivateMethod();
        ProtectedMethod();
    }
}

interface IFoo : IFooBase
{
    void PublicMethod()
    {
        Console.WriteLine("IFoo.PublicMethod");
        // PrivateMethod(); // 错误：无法访问
        ProtectedMethod();
    }
}

class Foo : IFoo
{
    
}

static class Usage
{
    public static void Demo()
    {
        var foo = new Foo();
        ((IFoo)foo).PublicMethod();
        ((IFooBase)foo).PublicMethod();
    }
}