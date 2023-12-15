using LinqToSQL.Entities;

namespace LinqToSQL.Repository {
    public class Repository : IRepository {
        public readonly List<Customer> customers = new List<Customer>();

        public int AddCustomer(Customer customer) {
            if (customer == null) 
                throw new ArgumentNullException(nameof(customer));
            
            customers.Add(customer);
            return customer.Id;
        }

        public int CountAllCustomers() {
            return customers.Count;
        }
        public List<Customer> GetAllCustomers() {
            return customers.ToList();
        }

        public string VerifyCustomerName(int customerId) {
            if (customerId < 0)
                throw new ArgumentOutOfRangeException(nameof(customerId));

            Customer customerToVerifyName = (from c in customers
                                             where c.Id == customerId
                                             select c).SingleOrDefault();
            if (customerToVerifyName != null) {
                Console.WriteLine(customerToVerifyName.Name);
            }
            else {
                Console.WriteLine("Customer not found");
            }
            return customerToVerifyName.Name;
        }

        public void RemoveCustomer(int customerId) {
            if (customerId < 0)
                throw new ArgumentOutOfRangeException(nameof(customerId));

            var customerToBeRemoved = customers.Find(c => c.Id == customerId);

            customers.Remove(customerToBeRemoved);
        }
        public void CustomerOrder(List<Customer> customer) {
            var customerOrder = customer
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var item in customerOrder) {
                Console.Write(item.Name + ", ");
            }
        }
    }
}
