using LinqToSQL.Repository;
using System.Xml.Linq;

namespace LinqToSQL.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime MemberStartDate { get; set; }

    }
}
