using EticaretAPI.Domain.Entites.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Application.Repostories
{
    public  interface IRepository <T> where T : BaseEntity
    {
        DbSet<T> Table {  get; }
    }
}
