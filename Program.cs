namespace Factory_Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            string? userInput = string.Empty;
            bool wrongInput = true;

            do
            {
                Console.WriteLine("What database would you like to work with?");
                Console.WriteLine("Type: sql\r\nType: mongo\r\nType: list\r\n");

                userInput = Console.ReadLine();

                if (userInput is "sql" or "mongo" or "list")
                {
                    wrongInput = false;
                }
                else
                {
                    Console.WriteLine("That wasnt one of the choices provided...");
                    Thread.Sleep(1000);
                }

            } while (wrongInput);
            Console.Clear();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach ( var product in products ) 
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price:c}");    
            }
            Console.ReadLine();
        }
    }
}
