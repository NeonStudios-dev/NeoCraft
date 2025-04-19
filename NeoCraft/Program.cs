using NeoCraft;
using NeoCraftMain;
// Removed unnecessary using directive
namespace NeoCraftMain
{
    public class Program
    {
        public static void Main()
        {
            //test modules
            bool TestMode = true;
 
            // Create an instance of NeoCraftMain
            // Replace with the correct class from the NeoCraftMain namespace
            var neoCraftMain = new NeoCraftCli(); // Replace 'NeoCraftMainClass' with the actual class name from the NeoCraftMain namespace
            // Call the NeoCraft method
            neoCraftMain.NeoCraft();
            if(File.Exists("FirstRun.txt") && TestMode ==false)
            {
                Console.WriteLine("Checking for first run file...");
                Thread.Sleep(2000);
                Console.WriteLine("First run file check complete.");
                Console.WriteLine("First run file exists.");
                neoCraftMain.NeoCraft();
            }
            else
            {
                Console.WriteLine("First run file does not exist.");
                File.Create("FirstRun.txt").Close();
                Console.WriteLine("First run file created.");
            FirstRun();
        }
    }
    static void FirstRun()
    {
        var accountManager = new Accountmgr();
        bool skipIntro = true;
        if(skipIntro == true)
        {
        Console.Clear();     
        accountManager.ShowMenu();
        } else{
        foreach(char c in "Seems like your new here, huh?") 
        {
            Console.Write(c);
            
            Thread.Sleep(20);
        }
        Console.WriteLine();
        Thread.Sleep(3000);
        foreach(char c in "Then let me introduce myself.") 
        {
            Console.Write(c);
            Thread.Sleep(30);
        }
        Console.WriteLine();
        Thread.Sleep(2000);
        foreach(char c in "I am nova, Your assistaint Im not an Ai but i will help you arround! :)") 
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
        Thread.Sleep(2000);
        foreach(char c in "So firstup, lets create a new account!") 
        {
            Console.Write(c);
            Thread.Sleep(40);
        }
        Console.WriteLine();
        Thread.Sleep(5000);        
        Console.Clear();
        accountManager.Regmgr();
        Console.WriteLine();
        // Add any additional logic you want to execute on the first run
        // For example, you can initialize settings or display a welcome message
        Console.WriteLine("Welcome to NeoCraft!");
        }
    }
}
    }
