﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Domain
{
    public interface IDBRepository<T>
          where T : class, IDBEntity
    {
        IQueryable<T> AllItems { get; }
        DbContext Context { get; }
        Task<List<T>> ToListAsync();
        Task<int> AddItemAsync(T item);
        Task<int> AddItemsAsync(IEnumerable<T> items);
        Task<T> GetItemAsync(Guid id);
        Task<bool> ChangeItemAsync(T item);
        Task<bool> DeleteItemAsync(Guid id);
        Task<int> SaveChangesAsync();
        Task<bool> UpdateItemAsync(T item);
    }
}