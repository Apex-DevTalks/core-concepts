class OC_Wrong
{
    // public class Printer
    // {
    //     public static void PrintMessage(string message)
    //     {
    //         Console.WriteLine(message);
    //     }
    // }
    
    // static void MyMain(string[] args)
    // {
    //     Printer.PrintMessage("Printing a message on the console...");
    //     Printer.PrintMessageOnFile("Printing a message on a file...");
        
    // }

    // ... some years have passed at this point

    public class Printer
    {
        public enum PrintOrSaveOption
        {
            Print,
            Save
        }
        public static void PrintOrSaveMessage(string message, PrintOrSaveOption option)
        {
            switch (option)
            {
                case PrintOrSaveOption.Print:
                    Console.WriteLine(message);
                    break;
                case PrintOrSaveOption.Save:
                   File.WriteAllText("MyFile.txt", message);
                   break;
            }
        }
    }
    static void MyMain(string[] args)
    {
        Printer.PrintOrSaveMessage("Printing a message...", Printer.PrintOrSaveOption.Print);
        Printer.PrintOrSaveMessage("Saving a message...", Printer.PrintOrSaveOption.Save);
    }
}