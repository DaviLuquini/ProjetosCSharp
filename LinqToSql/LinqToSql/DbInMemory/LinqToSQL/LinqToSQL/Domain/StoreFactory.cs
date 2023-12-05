using LinqToSQL.Entities;
using LinqToSQL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToSQL.Domain {
    public class StoreFactory {
        public static Store Create(IRepository repo, String name, DateTime releaseDate) {

            var store = new Store() 
            {
                Repository = repo,
                Name = name,
                ReleaseDate = releaseDate
            };

            return store;
        }
    }
}
