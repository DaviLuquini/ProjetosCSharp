using LinqToSQL.Entities;

namespace LinqToSQL.Repository
{
    public interface IRepository
    {
        int AddCustomer(Customer customer);
        void RemoveCustomer(int customerId);
        int GetAllCustomers();
        void VerifyCustomerName(int customerId);
        void CustomerOrder(List<Customer> customer);
    }
}
