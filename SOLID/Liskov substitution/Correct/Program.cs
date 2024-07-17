class LS_Correct
{
    public interface ISpeaker
    {
        string Name { get; }
        public void Speak();
    }
    public class Parent : ISpeaker
    {
        public string Name => "Parent";

        public void Speak()
        {
            Console.WriteLine("I'm speaking as a {0}...", Name);
        }
    }
    public class Child : ISpeaker
    {
        public string Name => "Child";
        public void Speak()
        {
            Console.WriteLine("I'm speaking as a {0}...", Name);
        }
    }
    public static class MyClass
    {
        public static void MakeSomeoneSpeak(ISpeaker speaker)
        {
            speaker.Speak();
        }
    }

    static void MyMain(string[] args)
    {
        MyClass.MakeSomeoneSpeak(new Parent());
        MyClass.MakeSomeoneSpeak(new Child());
    }
}