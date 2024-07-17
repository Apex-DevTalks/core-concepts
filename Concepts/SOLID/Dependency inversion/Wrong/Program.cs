class DI_Wrong
{
    class A
    {
        public static void DoSomething()
        {
            B b = new();
            C c = new();
            D d = new();
            Console.WriteLine("Concatenating type names...");
            Console.WriteLine("{0}, {1}, {2}", b.GetType().Name, c.GetType().Name, d.GetType().Name);
        }
    }
    class B
    {}
    class C
    {}
    class D
    {}
    
    static void MyMain(string[] args)
    {
        A a = new();
        A.DoSomething();
    }
}