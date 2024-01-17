namespace AllAboutInterface.Basics.MethodWithImpl;

public interface IMethodWithImpl
{
    void MethodWithImpl()
    {
        Console.WriteLine($"这是接口{nameof(IMethodWithImpl)}中的一个包含默认实现的方法");
    }

    void AnotherMethodWithImpl()
    {
        Console.WriteLine($"这是接口{nameof(IMethodWithImpl)}中的另一个包含默认实现的方法");
    }
}

public class DemoClass1 : IMethodWithImpl
{
    // 实现了接口后，该类不必实现接口中包含默认实现的方法
    public void AnotherMethodWithImpl()
    {
        Console.WriteLine($"这是{nameof(DemoClass1)}类对于接口中带有默认实现的方法的实现");
    }
}

public class DemoClass2 : IMethodWithImpl
{
}