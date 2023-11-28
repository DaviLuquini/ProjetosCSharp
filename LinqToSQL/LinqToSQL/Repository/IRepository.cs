using LinqToSQL.Entities;

namespace LinqToSQL.Repository
{
    public interface IRepository
    {
        int AddCustomer(Custumer custumer);
        void RemoveCustomer(int customerId);
        int GetAllCustumers();
    }
}
