using ProfileAPI.Models;
using ProfileAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileAPI.Service
{
    public class CustomerService : ICustomerService<CustomerDetail>
    {
        private readonly ICustomerRepo<CustomerDetail> repo;
        public CustomerService(ICustomerRepo<CustomerDetail> _repo)
        {
            repo = _repo;
        }

        public CustomerDetail EditProfile(int id, CustomerDetail c)
        {
            return repo.EditProfile(id, c);
        }

        public CustomerDetail ViewProfile(int id)
        {
            return repo.ViewProfile(id);
        }
    }
}
