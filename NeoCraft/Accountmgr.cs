
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using NeoCraftMain;
namespace NeoCraft
{
    public class Accountmgr
    {
        private const string UserDatabaseFile = "userDatabase.json";
        private Dictionary<string, string> userDatabase;

        public Accountmgr()
        {
            LoadUserDatabase();
        }

        private void LoadUserDatabase()
        {
            if (File.Exists(UserDatabaseFile))
            {
                string json = File.ReadAllText(UserDatabaseFile);
                userDatabase = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
            }
            else
            {
                userDatabase = new Dictionary<string, string>();
            }
        }

        private void SaveUserDatabase()
        {
            string json = JsonSerializer.Serialize(userDatabase, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(UserDatabaseFile, json);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("=== Welcome to NeoCraft ===");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Regmgr();
                        break;
                    case "2":
                        Loginmgr();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public void Regmgr()
        {
            Console.WriteLine("=== Registration ===");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (userDatabase.ContainsKey(username))
            {
                Console.WriteLine("Username already exists. Please try again.");
                return;
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            string hashedPassword = HashPassword(password);
            userDatabase[username] = hashedPassword;
            SaveUserDatabase();
            Console.WriteLine("Registration successful!");
        }

        public void Loginmgr()
        {
            var neoCraftMain = new NeoCraftCli();
            Console.Clear();
            Console.WriteLine("=== Login ===");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (!userDatabase.ContainsKey(username))
            {
                Console.WriteLine("Username not found. Please register first.");
                Regmgr();
                return;
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            string hashedPassword = HashPassword(password);

            if (userDatabase[username] == hashedPassword)
            {
                Console.WriteLine("Login successful!");
                neoCraftMain.NeoCraft();
            }
            else
            {
                Console.WriteLine("Incorrect password. Please try again.");
            }
        }
    }
}