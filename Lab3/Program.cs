using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Account
    {
        private int id;
        private string name;
        private string email;
        private string branch;
        private float balance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string ID { get; private set; }

        // Default constructor
        public Account()
        {
            this.Id = 0; // Default ID
            this.Name = "Unknown"; // Default name
            this.Email = "unknown@example.com"; // Default email
            this.Branch = "Default Branch"; // Default branch
            this.Balance = 0.0f; // Default balance
        }

        // Parameterized constructor
        public Account(int id, string name, string email, string branch, float balance)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Branch = branch;
            this.Balance = balance;
        }

        // Method to withdraw an amount
        public void Withdraw(float amount)
        {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine("Successfully withdrew. New balance is: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        // Method to deposit an amount
        public void Deposit(float amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Successfully deposited " + amount + ". New balance is " + balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Method to transfer amount from one account to another
        public void Transfer(Account targetAccount, float amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                this.balance -= amount;
                targetAccount.Deposit(amount);
                Console.WriteLine("Transferred " + amount + " from " + this.Name + " to " + targetAccount.Name);
            }
            else
            {
                Console.WriteLine("Transfer failed: Invalid amount or insufficient balance.");
            }
        }

        public void Display()
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Branch: " + Branch);
            Console.WriteLine("Balance: " + Balance);
        }

        public static void Main(string[] args)
        {
            Account acc1 = new Account(1, "MD. Nazmus Sadat Numan", "nazmussadatnuman92@gmail.com", "Pangsha, Rajbari", 1000.0f);
            Account acc2 = new Account(2, "Sadat Numan", "nazmussadatnuman93@gmail.com", "Pangsha, Rajbari", 500.0f);

            Console.Write("\n\n");
            Console.WriteLine("\nInitial Account Details:");
            acc1.Display();
            Console.Write("\n");
            acc2.Display();

            Console.WriteLine("\nPerforming Transfer:");
            acc1.Transfer(acc2, 300.0f);
            Console.Write("\n");
            acc1.Transfer(acc2, 30000.0f);

            Console.WriteLine("\nUpdated Account Details:");
            acc1.Display();
            Console.Write("\n");
            acc2.Display();

            Console.Write("\nAdditional Transactions:\n");
            acc1.Deposit(200.0f);
            acc1.Withdraw(100.0f);
            acc1.Withdraw(2000.0f);

            Console.WriteLine("\nFinal Account Details:");
            acc1.Display();
            Console.Write("\n");
            acc2.Display();
        }
    }
}
