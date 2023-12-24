using EticaretAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Domain.Entites
{
    public class Customer :BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Orders> orders { get; set; }
    }
}
