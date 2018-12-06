using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Preapproval.Models;

namespace Preapproval.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        Item person = new Item();

        public MockDataStore()
        {
            //var mockItems = new List<Item>
            //{
            //    new Item { Id = Guid.NewGuid().ToString(), Name = "First item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            //};

            //foreach (var item in mockItems)
            //{
            //    items.Add(item);
            //}
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            person = item;
            //items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            //var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            //items.Remove(oldItem);
            //items.Add(item);
            person = item;
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync()
        {
            //var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            //items.Remove(oldItem);
            person = new Item();
            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync()
        {
            return await Task.FromResult(person);
        }
    }
}