using LinqToSQL.Domain;
using LinqToSQL.Entities;
using LinqToSQL.Repository;
public class Program {
    static void Main(string[] args) {
        IRepository amazonRepository = new Repository();
        IRepository americanasRepository = new Repository();
        //Criar lojas
        var stores = new List<Store> {
            StoreFactory.Create(amazonRepository, "Amazon",new DateTime(1980,10,15)),
            StoreFactory.Create(americanasRepository, "Americanas",new DateTime(1989,12,15))
        };
        //Criar e adicionar clientas da Amazon ao repositorio
        var amazonCustomers = new List<Customer> {
            CustomerFactory.Create(1, "Davi", 18, new DateTime(2010,10,15)),
            CustomerFactory.Create(2, "Pedro", 22, new DateTime(2012,09,29)),
            CustomerFactory.Create(3, "Laila", 16, new DateTime(2000,11,17))
        };

        var amazonCustomersToAdd = from c in amazonCustomers
                             where c.Age >= 10
                             select c;

        foreach (var customer in amazonCustomersToAdd) {
            amazonRepository.AddCustomer(customer);
        }

        //Criar e adicionar clientas da Americanas ao repositorio
        var americanasCustomers = new List<Customer> {
            CustomerFactory.Create(1, "Paulo", 40, new DateTime(2006, 10, 05)),
            CustomerFactory.Create(2, "Andre", 32, new DateTime(2020, 12, 29)),
            CustomerFactory.Create(3, "Saulo", 42, new DateTime(2010, 11, 05)),
            CustomerFactory.Create(4, "Luiza", 13, new DateTime(2022, 08, 10))
        };

        var americanasCustomersToAdd = from c in americanasCustomers
                                   where c.Age >= 10
                                   select c;

        foreach (var customer in americanasCustomersToAdd) {
            americanasRepository.AddCustomer(customer);
        }

        Console.WriteLine("Choose which store you'd like to see about: Amazon or Americanas?");
        string storeChosen = Console.ReadLine();
        if(storeChosen == "Amazon") {
            Console.WriteLine("Store 1 name: " + stores[0].Name);
            Console.WriteLine("Total " + stores[0].Name + " Customers = " + stores[0].CalculateTotalCustomers());
            Console.Write("Number 1 Amazon Customer : ");
            amazonRepository.VerifyCustomerName(1);           
            Console.Write("Amazon Customers in alphabetical order: ");
            amazonRepository.CustomerOrder(amazonCustomers);
        } else {
            Console.WriteLine("Store 2 name: " + stores[1].Name);
            Console.WriteLine("Total " + stores[1].Name + " Customers = " + stores[1].CalculateTotalCustomers());
            Console.Write("Number 1 Americanas Customer : ");
            americanasRepository.VerifyCustomerName(1);
            Console.Write("Americanas Customers in alphabetical order: ");
            americanasRepository.CustomerOrder(americanasCustomers);
            americanasRepository.RemoveCustomer(1);
            Console.WriteLine("1 Americanas customer removed, new total customers = " + stores[1].CalculateTotalCustomers());
        }
    }
}


