using MentalHealth;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to MentalHealth Tracker");
            Console.WriteLine("============================================================================================================================");
            Console.WriteLine("Enter 1 to add user");
            Console.WriteLine("Enter 2 to view user");
            Console.WriteLine("Enter 3 to update user");
            Console.WriteLine("Enter 4 to delete user");
            Console.WriteLine("Enter 5 to Display all users");
            Console.WriteLine("Enter 6 to exit");
            Console.WriteLine("============================================================================================================================");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            User obj = new User();
            switch (choice)
            {
                case 1:
                    obj.Adduser();
                    break;
                case 2:
                    obj.Searchuser();
                    break;
                case 3:
                    obj.Updateuser();
                    break;
                case 4:
                    obj.Deleteuser();
                    break;
                case 5:
                    obj.Displayuser();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}