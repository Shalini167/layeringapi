using ProfileAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileAPI.Repository
{
    public class CustomerRepo : ICustomerRepo<CustomerDetail>
    {
        private readonly ICustomerDetail<CustomerDetail> obj;

        public CustomerRepo(ICustomerDetail<CustomerDetail> _obj)
        {
            obj = _obj;

        }

        public CustomerDetail EditProfile(int id, CustomerDetail c)
        {
            return obj.EditProfile(id, c);
        }

        public CustomerDetail ViewProfile(int id)
        {
            return obj.ViewProfile(id);
        }
    }
}
