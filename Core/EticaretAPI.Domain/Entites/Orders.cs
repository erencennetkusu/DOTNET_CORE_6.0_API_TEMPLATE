using EticaretAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Domain.Entites
{
    public class Orders : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description  { get; set; }
        public string Adresss { get; set; }

        public ICollection<Product> products { get; set; }

        public Customer  Customer { get; set; }
    }
}
