using System.Collections.ObjectModel;

namespace AllAboutInterface.Basics.ExplicitImpl;

interface IFoo1
{
    void Foo();
}

interface IFoo2
{
    void Foo();
}

/*
 * 如果多个接口包含签名相同的方法，那么类可以：
 * 1. 分别用显式实现的方式实现这些接口
 * 2. 使用传统的隐式实现，一次性实现两个接口中的方法
 */

class DemoClass1 : IFoo1, IFoo2
{
    // public void Foo()
    // {
    // }

    void IFoo1.Foo()
    {
        throw new NotImplementedException();
    }

    void IFoo2.Foo()
    {
        throw new NotImplementedException();
    }
}

class DemoClass2 : IFoo1, IFoo2
{
    // 这个方法不是来自于任意一个接口，而是 DemoClass2 自己的方法
    public void Foo()
    {
        
    }
}

class Usage
{
    public static void Demo()
    {
        var demo = new DemoClass1();
        ((IFoo1)demo).Foo();
        ((IFoo2)demo).Foo();
        CallFoo(demo);

        Display(new List<int>());
        Display(new int[0]);

        // var dict = new ReadOnlyDictionary<>();
        // ((IDictionary<>)dict).Add();
        
    }

    static void CallFoo(IFoo1 demo)
    {
        demo.Foo();
    }

    static void Display(IEnumerable<int> array)
    {
        foreach (var n in array)
        {
            Console.WriteLine(n);
        }
    }
}