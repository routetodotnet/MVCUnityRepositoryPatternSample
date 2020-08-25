using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessService
{
    public interface ICustomerRepository:IRepository<Customer>
    {

        IEnumerable<Customer> GetCustomersByCountry(string country);
    }

}
