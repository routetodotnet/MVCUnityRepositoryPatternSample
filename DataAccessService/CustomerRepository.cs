using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessService
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        public readonly TESTDBEntities _customerDbEntities;
        public CustomerRepository(TESTDBEntities context):base(context)
        {

            _customerDbEntities = context;
        }
        public IEnumerable<Customer> GetCustomersByCountry(string country)
        {
            return _customerDbEntities.Customers.OrderByDescending(a => a.Country).ToList();
        }
    }

}
