using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessService
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Customer> CustomerRepository { get; }
        void Save();
    }
    public partial class UnitOfWork : IUnitOfWork
    {
        private IRepository<Customer> _customerRepository;
        private TESTDBEntities _context;
        public IRepository<Customer> CustomerRepository
        {
            get
            {

                if (_customerRepository == null)
                    _customerRepository = new Repository<Customer>(_context);
                return _customerRepository;
            }
        }


        public UnitOfWork()
        {
            _context = new TESTDBEntities();
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

}
