using System;

class Person
{
    protected string name;
    protected string dob;

    public Person()
    {
        this.name = "Unknown";
        this.dob = "0000-00-00";
    }

    public Person(string name, string dob)
    {
        this.name = name;
        this.dob = dob;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setDob(string dob)
    {
        this.dob = dob;
    }

    public string getName()
    {
        return name;
    }

    public string getDob()
    {
        return dob;
    }
}

class Account
{
    private int id;
    private float balance;

    public Account()
    {
        this.id = 0;
        this.balance = 0.0f;
    }

    public Account(int id, float balance)
    {
        this.id = id;
        this.balance = balance;
    }

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public float getBalance()
    {
        return balance;
    }

    public void setBalance(float balance)
    {
        this.balance = balance;
    }

    public void Withdraw(float amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Successfully withdrew: " + amount + ". New balance is: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    public void Deposit(float amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Successfully deposited " + amount + ". New balance is: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Transfer(Account targetAccount, float amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            targetAccount.Deposit(amount);
            Console.WriteLine("Transferred " + amount);
        }
        else
        {
            Console.WriteLine("Transfer failed: Invalid amount or insufficient balance.");
        }
    }

    public void Display()
    {
        Console.WriteLine("Account ID: " + id);
        Console.WriteLine("Account Balance: " + balance);
    }
}

class Employee : Person
{
    private static int employeeCounter = 0;
    private string employeeId;
    private Account acc;

    public Employee() : base()
    {
        employeeCounter++;
        this.employeeId = employeeCounter.ToString("D2");
        this.acc = new Account();
    }

    public Employee(string name, string dob, Account acc) : base(name, dob)
    {
        employeeCounter++;
        this.employeeId = employeeCounter.ToString("D2");
        this.acc = acc;
    }

    public void setAcc(Account acc)
    {
        this.acc = acc;
    }

    public void display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("DOB: " + dob);
        acc.Display();
    }

    public Account getAccount()
    {
        return acc;
    }
}

class Customer : Person
{
    private static int customerCounter = 0;
    private string customerId;
    private Account acc;

    public Customer() : base()
    {
        customerCounter++;
        this.customerId = customerCounter.ToString("D2");
        this.acc = new Account();
    }

    public Customer(string name, string dob, Account acc) : base(name, dob)
    {
        customerCounter++;
        this.customerId = customerCounter.ToString("D2");
        this.acc = acc;
    }

    public void setAcc(Account acc)
    {
        this.acc = acc;
    }

    public void display()
    {
        Console.WriteLine("Customer ID: " + customerId);
        Console.WriteLine("Customer Name: " + name);
        Console.WriteLine("DOB: " + dob);
        acc.Display();
    }

    public Account getAccount()
    {
        return acc;
    }
}

class Program
{
    static void Main(string[] args)
    {
  
        Employee a = new Employee("Sadat Numan", "30-08-2003", new Account(1001, 5000));
        Employee b = new Employee("Numan", "31-08-2003", new Account(1002, 3000));

        Customer c = new Customer("Sadat", "29-08-2003", new Account(2001, 1000));
        Customer d = new Customer("MD. Nazmus Sadat Numan", "28-08-2003", new Account(2002, 2000));

  
        Employee defaultEmployee = new Employee();
        Customer defaultCustomer = new Customer();

      
        Console.WriteLine("Initial Details:\n");
        a.display();
        Console.WriteLine("\n");
        b.display();
        Console.WriteLine("\n");
        c.display();
        Console.WriteLine("\n");
        d.display();

        Console.WriteLine("\n\n");
        Console.WriteLine("\nDefault Employee Details:\n");
        defaultEmployee.display();

        Console.WriteLine("\nDefault Customer Details:\n");
        defaultCustomer.display();

    
        Console.WriteLine("\n\nTransfer:");
        a.getAccount().Transfer(b.getAccount(), 1000);

       
        Console.WriteLine("\n\nWithdraws:");
        c.getAccount().Withdraw(500);

    
        Console.WriteLine("\n\nDeposits:");
        d.getAccount().Deposit(800);

       
        Console.WriteLine("\n\nFinal Details:\n");
        a.display();
        Console.WriteLine("\n");
        b.display();
        Console.WriteLine("\n");
        c.display();
        Console.WriteLine("\n");
        d.display();
    }
}
