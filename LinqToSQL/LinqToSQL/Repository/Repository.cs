
using LinqToSQL.Entities;

namespace LinqToSQL.Repository
{
    public class Repository : IRepository
    {
        private readonly List<Custumer> custumers = new List<Custumer>();

        public int AddCustomer(Custumer custumer)
        {
            custumers.Add(custumer);

            return custumer.Id;
        }

        public int GetAllCustumers()
        {
            return custumers.Count;
        }

        public void RemoveCustomer(int customerId)
        {
            var custumerToBeRemoved = custumers.Find(c => c.Id == customerId);

            custumers.Remove(custumerToBeRemoved);
        }
    }
}
