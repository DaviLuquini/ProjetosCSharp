using LinqToSQL.Repository;

namespace LinqToSQL.Entities
{
    public class Store
    {
        public IRepository Repository;
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    
        public int CalculateTotalCustomers()
        {   
            return Repository.GetAllCustomers();
        }
    }
}
