#nullable disable warnings

using System.Text.Json;

namespace AllAboutInterface.Basics.AbstractStaticMethod;

/*
 * 接口中的方法本身就类似于抽象类中的抽象方法，要求子类必须实现
 * 接口中允许存在静态方法，而静态方法又必须在接口中给出实现
 * 所以如果希望接口中存在可以不在接口中实现的静态方法，就需要声明为抽象方法
 */

interface IAbstractStaticMethod
{
    static abstract string Foo();
}

class DemoClass : IAbstractStaticMethod
{
    public static string Foo()
    {
        return nameof(DemoClass);
    }
}

#region 经典用法：Deserialize

interface IDeserializable<T> where T : IDeserializable<T>
{
    static abstract T Deserialize(string json);
}

class MyDataModel : IDeserializable<MyDataModel>
{
    public static MyDataModel Deserialize(string json)
    {
        return JsonSerializer.Deserialize<MyDataModel>(json);
    }
}

#endregion

#region 经典用法：Factory

interface IFactory<T>
{
    static abstract T Create();
}

class ClassToBeCreated
{
}

class ClassWithFactoryMethod : IFactory<ClassToBeCreated>
{
    private ClassWithFactoryMethod()
    {
    }

    public static ClassToBeCreated Create()
    {
        return new ClassToBeCreated();
    }
}

#endregion

#region 经典用法：Singleton

interface ISingleton<T> where T : ISingleton<T>
{
    static abstract T Instance { get; }
}

class SingletonClass : ISingleton<SingletonClass>
{
    // public static SingletonClass Instance { get; } = new SingletonClass();

    private static readonly Lazy<SingletonClass> _instanceHolder = new(() => new SingletonClass());
    public static SingletonClass Instance => _instanceHolder.Value;

    // public static SingletonClass Instance { get; } = new();
}

#endregion

#region 经典用法：Operators

interface IOperators<T> where T : IOperators<T>
{
    static abstract T operator +(T left, T right);
    static abstract T operator -(T left, T right);
}

class MyNumber : IOperators<MyNumber>
{
    public int Value { get; }

    public MyNumber(int value)
    {
        Value = value;
    }

    public static MyNumber operator +(MyNumber left, MyNumber right)
    {
        return new MyNumber(left.Value + right.Value);
    }

    public static MyNumber operator -(MyNumber left, MyNumber right)
    {
        return new MyNumber(left.Value - right.Value);
    }
}

#endregion

class Usage
{
    public static void Demo()
    {
        DemoClass.Foo();
    }
}