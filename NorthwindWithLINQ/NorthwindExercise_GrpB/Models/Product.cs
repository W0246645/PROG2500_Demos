using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindExercise_GrpB.Models
{
    public partial class Product
    {
        public string FormattedPrice
        {
            get
            {
                return string.Format("Price: ${0:N2}", UnitPrice);
            }
        }
    }
}
