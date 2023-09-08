﻿namespace AlchemyUmsa.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        //T GetById(int id);
        //IEnumerable<T> GetAll();
        //void Add(T entity);
        //void Update(T entity);

        //void Delete(T entity);

    }
}
