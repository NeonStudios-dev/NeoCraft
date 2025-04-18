using NeoCraftMain;

namespace NeoCraft
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of NeoCraftMain
            // Replace with the correct class from the NeoCraftMain namespace
            var neoCraftMain = new NeoCraftCli(); // Replace 'NeoCraftMainClass' with the actual class name from the NeoCraftMain namespace
            // Call the NeoCraft method
            neoCraftMain.NeoCraft();
            if(File.Exists("FirstRun.txt"))
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
        }
    }
}
}