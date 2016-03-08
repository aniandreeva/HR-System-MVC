﻿using ProjectSummary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectSummary.Repositories
{
    public class BaseRepository<T> where T : BaseModel, new()
    {
        protected readonly AppContext context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository()
        {
            this.context = new AppContext();
            this.dbSet = context.Set<T>();
        }
        
        public T GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        private void Insert(T item)
        {
            dbSet.Add(item);
        }
        private void Update(T item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            dbSet.Remove(GetByID(id));
            context.SaveChanges();
        }
        public void Save(T item)
        {
            if (item.ID>0)
            {
                Update(item);
            }
            else
            {
                Insert(item);
            }
            context.SaveChanges();
        }
    }
}