using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProfileAPI.Models
{
    public partial class CustomerDetail:ICustomerDetail<CustomerDetail>
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long? Phone { get; set; }
        public string Password { get; set; }
        public pharmvcContext db = new pharmvcContext();
        public CustomerDetail ViewProfile(int id)
        {
            CustomerDetail c = db.CustomerDetails.Find(id);
            return c;
        }

        public CustomerDetail EditProfile(int id, CustomerDetail c)
        {
             db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
            return c;
        }
    }
}
