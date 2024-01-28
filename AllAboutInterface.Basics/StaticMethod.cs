using System.Text.Json;

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

interface IDeserializable<T> where T : IDeserializable<T>
{
    static T? Deserialize(string json) => JsonSerializer.Deserialize<T>(json);
}

class Student : IDeserializable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"Id: {Id}, Name: {Name}";
}

class Usage
{
    public static void Demo()
    {
        // DemoClass.StaticMethod();
        IStaticMethod.StaticMethod();
        
        var student = IDeserializable<Student>.Deserialize("{\"Id\":42,\"Name\":\"Tom\"}");
        Console.WriteLine(student);
    }
}