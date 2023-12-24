using EticaretAPI.Application.Repostories;
using EticaretAPI.Domain.Entites.Common;
using EticaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Persistence.Repostories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly EticaretAPIDbContext _eticaretAPIDbContext;

        public ReadRepository(EticaretAPIDbContext eticaretAPIDbContext)
        {
            _eticaretAPIDbContext = eticaretAPIDbContext;
        }

        public DbSet<T> Table => _eticaretAPIDbContext.Set<T>();

        public IQueryable<T> GetAll()
            => Table;


        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
    }
}
