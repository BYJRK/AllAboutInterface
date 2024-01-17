#pragma warning disable CS0067

namespace AllAboutInterface.Basics;

/* 笔记
 *
 * 接口中的属性和事件与类中的并不相同：
 * - 接口中的属性和实现其实只是在声明属性的 getter/setter 以及事件的 add/remove
 * - 类中的属性和事件则会后台生成对应的私有字段
 *
 * 索引器则类似：
 * - 接口中只是在声明索引器的 getter/setter
 * - 类中的索引器除非被标记为了 abstract，否则必须给出默认实现
 */

public interface IPropertyAndEvent
{
    string Name { get; set; }

    string this[string key] { get; set; }

    event EventHandler? OnNameChanged;
}

public class ClassWithPropertyAndEvent
{
    public string Name { get; set; } = "";

    public string this[string key]
    {
        get => "";
        set { }
    }

    public event EventHandler? OnNameChanged;
}