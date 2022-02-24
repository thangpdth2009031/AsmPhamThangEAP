using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfService1.Entity;

namespace WcfService1.Data
{
    public class DbEmployee:DbContext
    {
        public DbEmployee():base("name=MyConnectionString")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }

}