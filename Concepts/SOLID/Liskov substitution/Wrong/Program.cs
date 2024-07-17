class LS_Wrong
{
    public class Parent
    {
        public virtual void Speak()
        {
            Console.WriteLine("I'm speaking as a parent...");
        }
    }
    public class Child : Parent
    {
        override public void Speak()
        {
            Console.WriteLine("I'm speaking as a child...");
        }
    }

    static void MyMain(string[] args)
    {
        Parent parent = new Child();
        parent.Speak();
    }
}