using LinqToSQL.Repository;

namespace LinqToSQL.Entities
{
    public class Loja
    {
        private IRepository repository;
        public string Name { get; set; }
        private int totalCustumers { get; set; }

        public Loja(IRepository repo)
        {
            repository = repo;
            totalCustumers = calcularTotalCustumers();
        }


        public int calcularTotalCustumers()
        {
            return repository.GetAllCustumers();
        }
    }
}
