using System;
using System.IO;

public class ProcessFile
{
    private const string Message = @"[data.txt not in C:\Users\STUDENT-4310\source\repos\ConsoleApp5\ConsoleApp5\bin\Debug\net5.0]";

    public static void Main()
    {
        FileStream fs;
        try
        {
            // Opens a text tile.
            fs = new FileStream(@"C:\Users\STUDENT-4310\source\repos\ConsoleApp5\ConsoleApp5\bin\Debug\net5.0\data.txt", FileMode.Open);
            var sr = new StreamReader(fs);

            // A value is read from the file and output to the console.
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"[Data File Missing] {e}");
            throw new FileNotFoundException(Message, e);
        }
        finally
        {
            if (fs != null)
                fs.Close();
        }
    }
}