namespace Prog_3_W24_L3_012924
{
    internal class Program
    {
        static int age = 323;

        static void Main(string[] args)
        {

            // access modifiers
            // private - Only the current class has access
            // protected

            // public

            // protected

            Account will = new Account("Will", 500);
            Account manjula = new Account("Majula", 5000000);
            

            Console.WriteLine(will.ToString());
            Console.WriteLine(manjula.ToString());

            Account.TransferMoney(will, manjula, 500);


            Console.WriteLine(will.ToString());
            Console.WriteLine(manjula.ToString());

            Console.Write("Enter 1 to connect to the database: ");
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                ConnectToDatabase(Config.connectionString);
            }


            // static

            // abstract




        } // main

        public static void ConnectToDatabase(string connectionString)
        {
            if(connectionString != "")
            {
                Console.WriteLine("You have connected to your database");
            }
            else
            {
                Console.WriteLine("Empty Connection String");
            }
            
        }

        public static void StaticExample()
        {

            Account newAccount = new Account("Will", 500);

            Console.WriteLine(newAccount.ToString());

            Account.IncreaseBalance(newAccount);

            Console.WriteLine(newAccount.ToString());


            //Console.WriteLine(newAccount.ToString());

            //Account secondAccount = new Account("Manjula", 5000000);

            //Console.WriteLine(secondAccount.ToString());

            //Account thirdAccount = new Account("Lisa", 50000000);

            //Console.WriteLine(thirdAccount.ToString());

            //// Access a static field
            //Console.WriteLine("Current Number Of Accounts: " + Account.NumberOfAccounts);
            //Console.WriteLine($"Instance numer of accounts: {thirdAccount.InstanceNumberOfAccounts}");

        }

    } // class

} // namespace
