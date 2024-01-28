namespace AllAboutInterface.Basics.MethodWithDefaultImpl;

/*
 * C# 8.0 中引入了接口中的默认实现
 */

public interface IFoo1
{
    void Foo()
    {
        Console.WriteLine($"这是接口{nameof(IFoo1)}中的一个包含默认实现的方法");
    }

    void Bar()
    {
        Console.WriteLine($"这是接口{nameof(IFoo1)}中的另一个包含默认实现的方法");
    }
}

public interface IFoo2
{
    void Foo()
    {
        Console.WriteLine($"这是接口{nameof(IFoo2)}中的一个包含默认实现的方法");
    }
}

public class DemoClass1 : IFoo1, IFoo2
{
    // 实现了接口后，该类不必实现接口中包含默认实现的方法
    // 如果实现，那么接口中的默认实现将会直接被忽略

    // NOTE：因为一定会被忽略，所以被忽略的方法究竟出自哪个接口，是无所谓的

    public void Bar()
    {
        Console.WriteLine($"这是{nameof(DemoClass1)}类对于接口中带有默认实现的方法的实现");
    }
}

static class Usage
{
    public static void Demo()
    {
        var demo = new DemoClass1();

        // 类无法直接调用接口中的方法，需要显式使用接口对象
        // 因为编译器不能保证是否只有一个接口提供了这一签名的方法的默认实现
        // demo.MethodWIthImpl();
        ((IFoo1)demo).Foo();
        demo.Bar();
        
        // 由于类实现了接口中的方法，因此即便显式使用接口对象，也依旧会调用自己的实现
        ((IFoo1)demo).Bar();
    }
}
