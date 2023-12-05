using LinqToSQL.Entities;
using LinqToSQL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL.Domain {
    public class CustomerFactory {
            public static Customer Create(int id, String name, int age, DateTime memberStartDate) {

                var customer = new Customer() 
                {
                   Id = id,
                   Name = name,
                   Age = age,
                   MemberStartDate = memberStartDate,
                };

                return customer;
            }
        }
    }
