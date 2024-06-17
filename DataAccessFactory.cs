
namespace Factory_Pattern2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(String databaseType)
        { 
            switch(databaseType.ToLower()) 
            {
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                    return new SQLDataAcces();
                case "list":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();                    
            }
        }
    }
}
