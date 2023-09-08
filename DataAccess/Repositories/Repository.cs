﻿using AlchemyUmsa.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AlchemyUmsa.DataAccess.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
