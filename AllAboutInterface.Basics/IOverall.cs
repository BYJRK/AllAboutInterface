namespace AllAboutInterface.Basics;

public interface IOverall
{
    // 最普通的方法
    void Foo();
    
    // 属性
    string Name { get; set; }
    
    // 索引器
    int this[int index] { get; set; }
    
    // 事件
    event EventHandler OnNameChanged;

    // 带默认实现的方法
    void Bar() => Console.WriteLine("Bar");

    // 私有方法（需要带默认实现）
    private void NonPublicMethod1()
    {
    }

    // 受保护方法（需要带默认实现）
    protected void NonPublicMethod2()
    {
    }

    // 静态方法（需要带默认实现）
    static void StaticMethod()
    {
        Console.WriteLine("StaticMethod");
    }

    // 抽象静态方法
    static abstract void AbstractStaticMethod();
    
    // 虚静态方法（需要带默认实现）
    static virtual void VirtualStaticMethod()
    {
        Console.WriteLine("VirtualStaticMethod");
    }
}