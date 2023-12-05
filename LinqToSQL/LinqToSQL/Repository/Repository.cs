using LinqToSQL.Entities;

namespace LinqToSQL.Repository {
    public class Repository : IRepository {
        private readonly List<Customer> customers = new List<Customer>();

        public int AddCustomer(Customer customer) {
            customers.Add(customer);
            return customer.Id;
        }

        public int GetAllCustomers() {
            return customers.Count;
        }

        public void VerifyCustomerName(int customerId) {
            Customer customerToVerifyName = (from c in customers
                                             where c.Id == customerId
                                             select c).SingleOrDefault();
            if (customerToVerifyName != null) {
                Console.WriteLine(customerToVerifyName.Name);
            }
            else {
                Console.WriteLine("Customer not found");
            }
        }

        public void RemoveCustomer(int customerId) {
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
