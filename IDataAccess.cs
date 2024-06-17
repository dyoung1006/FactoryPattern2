
namespace Factory_Pattern2
{
    public interface IDataAccess
    {        
        public List<Product> LoadData();
        public void SaveData();
    }
}
