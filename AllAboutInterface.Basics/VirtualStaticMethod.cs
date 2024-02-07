﻿using System.Numerics;
using AllAboutInterface.Basics.ExplicitImpl;

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

    static void Bar()
    {
    }
}

interface IFoo : IVirtualStaticMethod
{
    static void Foo()
    {
        
    }
}

class DemoClass : IVirtualStaticMethod
{
    /// <inheritdoc cref="IVirtualStaticMethod.Foo"/>
    public static void Foo() // 无法使用 override 关键字
    {
        Console.WriteLine("Foo from class");
    }
}

class DemoClassDefault : IVirtualStaticMethod
{
}

static class Usage
{
    public static void Demo()
    {
        // IVirtualStaticMethod.Foo();
        DemoClass.Foo();             // Foo from class
        CallFoo<DemoClass>();        // Foo from class
        // DemoClassDefault.Foo();   // 找不到方法
        CallFoo<DemoClassDefault>(); // Foo from interface
    }
    
    public static void CallFoo<T>() where T : IVirtualStaticMethod
    {
        T.Foo();
    }
}
