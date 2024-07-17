public class LS_Correct2
{
    public class Speaker
    {
        public virtual void Speak()
        {
            Console.WriteLine("I'm speaking as a parent...");
        }
    }

    public class Adult : Speaker
    {
        override public void Speak()
        {
            Console.WriteLine("I'm speaking as an adult...");
        }
    }

    public class Teen : Speaker
    {
        override public void Speak()
        {
            Console.WriteLine("I'm speaking as a teen...");
        }
    }
    public class Kid : Speaker
    {
        override public void Speak()
        {
            Console.WriteLine("I'm speaking as a kid...");
        }
    }

    public static class SpeakMaker
    {
        public static void MakeSomeoneSpeak(Speaker speaker)
        {
            speaker.Speak();
        }
    }

    static void MyMain(string[] args)
    {
        SpeakMaker.MakeSomeoneSpeak(new Adult());
        SpeakMaker.MakeSomeoneSpeak(new Teen());
        SpeakMaker.MakeSomeoneSpeak(new Kid());
    }
}