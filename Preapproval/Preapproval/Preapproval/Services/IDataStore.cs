using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Preapproval.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync();
        Task<T> GetItemAsync();
    }
}
