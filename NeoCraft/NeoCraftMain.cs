using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoCraftMain
{
    public class NeoCraftCli
    {
        public void NeoCraft()
        {
            Console.Clear();
            foreach(char c in "Welcome back to NeoCraft!") 
                {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Thread.Sleep(5000);
            instanceMgr();
            
        }

    static void instanceMgr()
    {
       if(File.Exists("FirstRun.txt"))
        {
            Console.Clear();
            Console.WriteLine("Checking for first run file...");
            Thread.Sleep(2000);
            Console.WriteLine("First run file check complete.");
            Console.WriteLine("First run file exists.");
            Interface();
        }
        else
        {
            
        }

}
static void Interface()
{
    Console.Clear();
    Console.WriteLine("Welcome to NeoCraft!");
    Console.WriteLine("1. Create Instance");
    Console.WriteLine("2. Delete Instance");
    Console.WriteLine("3. Manage Instance");
    Console.WriteLine("4. Manage Accounts");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
            CreateInstance();
            break;
        case "2":
            DeleteInstance();
            break;
        case "3":
            ManageInstance();
            break;
        case "4":
            ManageAccounts();
            break;
        case "5":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            Thread.Sleep(2000);
            Interface();
            break;
    }
}
static void CreateInstance()
{
    Console.Clear();
    Console.WriteLine("=== Create Instance ===");
    Console.Write("Enter instance name: ");
    string instanceName = Console.ReadLine();
    
    // Logic to create an instance
    Console.WriteLine($"Instance '{instanceName}' created successfully!");
    Thread.Sleep(2000);
    Interface();
}
static void DeleteInstance()
{
    Console.Clear();
    Console.WriteLine("=== Delete Instance ===");
    Console.Write("Enter instance name to delete: ");
    string instanceName = Console.ReadLine();
    
    // Logic to delete an instance
    Console.WriteLine($"Instance '{instanceName}' deleted successfully!");
    Thread.Sleep(2000);
    Interface();
}
static void ManageInstance()
{
    Console.Clear();
    Console.WriteLine("=== Manage Instance ===");
    Console.Write("Enter instance name to manage: ");
    string instanceName = Console.ReadLine();
    
    // Logic to manage an instance
    Console.WriteLine($"Managing instance '{instanceName}'...");
    Thread.Sleep(2000);
    Interface();
}
static void ManageAccounts()
{
    Console.Clear();
    Console.WriteLine("=== Manage Accounts ===");
    Console.WriteLine("1. Create Account");
    Console.WriteLine("2. Delete Account");
    Console.WriteLine("3. View Accounts");
    Console.WriteLine("4. Back to Main Menu");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();
    
    switch (choice)
    {
        case "1":
            CreateAccount();
            break;
        case "2":
            DeleteAccount();
            break;
        case "3":
            ViewAccounts();
            break;
        case "4":
            Interface();
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            Thread.Sleep(2000);
            ManageAccounts();
            break;
    }
}
static void CreateAccount()
{
    Console.Clear();
    Console.WriteLine("=== Create Account ===");
    Console.Write("Enter account name: ");
    string accountName = Console.ReadLine();
    
    // Logic to create an account
    Console.WriteLine($"Account '{accountName}' created successfully!");
    Thread.Sleep(2000);
    ManageAccounts();
}
static void DeleteAccount()
{
    Console.Clear();
    Console.WriteLine("=== Delete Account ===");
    Console.Write("Enter account name to delete: ");
    string accountName = Console.ReadLine();
    
    // Logic to delete an account
    Console.WriteLine($"Account '{accountName}' deleted successfully!");
    Thread.Sleep(2000);
    ManageAccounts();
}
static void ViewAccounts()
{
    Console.Clear();
    Console.WriteLine("=== View Accounts ===");
    
    // Logic to view accounts
    Console.WriteLine("List of accounts:");
    // Example account list
    Console.WriteLine("1. Account1");
    Console.WriteLine("2. Account2");
    Console.WriteLine("3. Account3");
    
    Thread.Sleep(2000);
    ManageAccounts();
}
}
}