using DataAccessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnityRepositoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var unitofwork = new UnitOfWork())
            {
                unitofwork.CustomerRepository.Insert(new Customer()
                {
                     Id=100,Name="Test", Country="USA"
 

                });

                unitofwork.CustomerRepository.Insert(new Customer()
                {
                    Id = 101,
                    Name = "Test-101",
                    Country = "USA"


                });

                unitofwork.CustomerRepository.Insert(new Customer()
                {
                    Id = 102,
                    Name = "Test-102",
                    Country = "IND"


                });
               // var findcust = unitofwork.CustomerRepository.Get(a => a.Id == 100).Single();

                //Console.WriteLine($" id {findcust.Id} name :{findcust.Name} country :{findcust.Country} ");


                unitofwork.Save();
                Console.WriteLine("done");
                Console.ReadLine();



            }


        }
    }
}
