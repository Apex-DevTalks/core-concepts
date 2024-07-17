public class OC_Correct
{
    public class Printer
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

public static class PrinterExtensions
{
    public static void PrintMessageOnFile(this OC_Correct.Printer printer, string message)
    {
        File.WriteAllText("MyFile.txt", message);
    }
}

public class MyProgram
{
    public static void MyMyMain(string[] args) 
    {
        OC_Correct.Printer printer = new();
        printer.PrintMessage("Printing a message on the console...");
        printer.PrintMessageOnFile("Printing a message on a file...");
    }
}