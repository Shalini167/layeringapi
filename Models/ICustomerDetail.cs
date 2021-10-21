using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileAPI.Models
{
    public interface ICustomerDetail<CustomerDetail>
    {
        public CustomerDetail ViewProfile(int id);
        public CustomerDetail EditProfile(int id, CustomerDetail c);
    }
}
