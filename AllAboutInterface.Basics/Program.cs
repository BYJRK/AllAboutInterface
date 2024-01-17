using AllAboutInterface.Basics.MethodWithImpl;

var demo = new DemoClass1();

// 类无法直接调用接口中的方法，需要显式使用接口对象
// demo.MethodWIthImpl();
((IMethodWithImpl)demo).MethodWithImpl();
demo.AnotherMethodWithImpl();
// 由于类实现了接口中的方法，因此即便显式使用接口对象，也依旧会调用自己的实现
((IMethodWithImpl)demo).AnotherMethodWithImpl();

IMethodWithImpl demo2 = new DemoClass2();
demo2.MethodWithImpl();
demo2.AnotherMethodWithImpl();
