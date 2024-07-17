class DI_Correct
{
    class DependencyInversor
    {
        public B b = new();
        public C c = new();
        public D d = new();
    }
    class A
    {
        private readonly DependencyInversor _dependencyInversor;
        public A(DependencyInversor dependencyInversor)
        {
            _dependencyInversor = dependencyInversor;
        }
        public void DoSomething()
        {
            Console.WriteLine("Concatenating type names...");
            Console.WriteLine("{0}, {1}, {2}", _dependencyInversor.b.GetType().Name, _dependencyInversor.c.GetType().Name, _dependencyInversor.d.GetType().Name);
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
        A a = new A(new DependencyInversor());
    }
}