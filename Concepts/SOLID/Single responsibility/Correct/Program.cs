class SRP_Correct
{
    public class Printer
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void SaveMessage(string path, string message)
        {
            File.WriteAllText(path, message);
        }
    }
    static void MyMain(string[] args)
    {
        Printer.PrintMessage("Printing a message...");
        Printer.SaveMessage("MyFile.txt", "Saveing a message...");
    }
}