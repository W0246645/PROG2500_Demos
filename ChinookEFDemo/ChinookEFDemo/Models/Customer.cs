using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookEFDemo.Models
{
    public partial class Customer
    {
        public string FirstAndLastName { get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public void LogInCustomer()
        {
            //TODO
        }
    }
}
