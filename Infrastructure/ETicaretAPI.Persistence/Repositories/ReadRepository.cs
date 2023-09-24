﻿using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretDbContext _context;

        public ReadRepository(ETicaretDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table =>_context.Set<T>();

        public IQueryable<T> GetAll()=>  Table;


        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter)
        =>Table.Where(filter);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter)
        =>await Table.FirstOrDefaultAsync(filter);


        public async Task<T> GetByIdAsync(string id)

           //=>await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
           => await Table.FindAsync(Guid.Parse(id));

    }
}