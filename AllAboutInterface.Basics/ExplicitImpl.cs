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
    public void Foo()
    {
        
    }
}