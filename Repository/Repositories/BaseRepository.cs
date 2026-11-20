using Domain.Entities;
using Repository.Datas;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity)
        {
            AppDbContext<T>.datas.Add(entity);
        }

        public void Delete(T entity)
        {
            AppDbContext<T>.datas.Remove(entity);
        }

        public List<T> GetAll()
        {
            return AppDbContext<T>.datas;
        }

        public T GetById(int id)
        {
            return AppDbContext<T>.datas.FirstOrDefault(m => m.Id == id);
        }

        public void Update(T update)
        {
            AppDbContext<T>.datas[update.Id] = update;
        }
    }
}