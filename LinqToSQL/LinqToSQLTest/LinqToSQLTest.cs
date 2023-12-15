using LinqToSQL.Domain;
using LinqToSQL.Entities;
using LinqToSQL.Repository;
using NUnit.Framework;
using System;
using System.Numerics;

namespace LinqToSQLTest {
    public class Tests {
        private IRepository testRepository;

        [SetUp]
        public void Setup() {
            testRepository = new Repository();
        }

        [Test]
        public void AddCustomer_Should_Throw_When_Customer_Is_Null() {
            Assert.Throws<ArgumentNullException>(() => testRepository.AddCustomer(null));
        }
        
        [Test]
        public void AddCustomer() {

            var expectedCustomer =
                CustomerFactory.Create(1, "Davi", 18, new DateTime(2010, 10, 15));

            var result = testRepository.AddCustomer(expectedCustomer);

            Assert.That(expectedCustomer.Name, Is.TypeOf<string>());
            Assert.That(result, Is.TypeOf<int>());
            Assert.That(result, Is.EqualTo(expectedCustomer.Id));
        }

        [Test]
        public void RemoveCustomer_Should_Throw_When_CustomerId_Is_OutOfRange() {
            Assert.Throws<ArgumentOutOfRangeException>(() => testRepository.RemoveCustomer(-1));         
        }

        [Test]
        public void RemoveCustomer() {

            var newCustomer =
                CustomerFactory.Create(1, "Davi", 18, new DateTime(2010, 10, 15));

            var result = testRepository.AddCustomer(newCustomer);
            testRepository.RemoveCustomer(newCustomer.Id);

            var customerList = testRepository.GetAllCustomers();

            Assert.That(customerList, Has.No.Member(newCustomer));
            Assert.That(customerList, Is.Empty);
        }

        [Test]
        public void VerifyCustomerName_Should_Throw_When_CustomerId_Is_OutOfRange() {
            Assert.Throws<ArgumentOutOfRangeException>(() => testRepository.VerifyCustomerName(-1));
        }

        [Test]
        public void VerifyCustomerName() {
            var newCustomer =
               CustomerFactory.Create(1, "Davi", 18, new DateTime(2010, 10, 15));

            var result = testRepository.AddCustomer(newCustomer);

            var customerName = testRepository.VerifyCustomerName(result);

            Assert.That(customerName, Is.EqualTo(newCustomer.Name));
            Assert.That(customerName, Is.TypeOf<string>());
        }
    }
}