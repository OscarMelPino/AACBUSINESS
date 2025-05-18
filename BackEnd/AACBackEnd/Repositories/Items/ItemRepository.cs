using AACBackEnd.Database;
using AACBackEnd.Models.Items;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace AACBackEnd.Repositories.Items
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Item> AddItem(Item item)
        {
            try
            {
                _context.AAC_ITEMS.Add(new Database.DBModels.AAC_ITEMS
                {
                    Name = item.Name,
                });
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                // Log the exception
                return null;
            }
        }

        // Zeddy said to delete this. Im keeping it!

        //public async Task<bool> DeleteItem(int id)
        //{
        //    var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted, Timeout = TimeSpan.FromSeconds(30) };
        //    using (var transaction = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
        //    {
        //        try
        //        {
        //            _context.AAC_ITEMS.Remove(new Database.DBModels.AAC_ITEMS { Id = id });
        //            await _context.SaveChangesAsync();
        //            transaction.Complete();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            // Log the exception
        //            return false;
        //        }
        //    }
        //}

        public async Task<List<Item>> GetAllItems()
        {
            var items = await _context.AAC_ITEMS.ToListAsync();

            List<Item> itemsList = new List<Item>();
            foreach (var item in items)
            {
                itemsList.Add(new Item
                {
                    ItemId = item.ItemId,
                    Name = item.Name,
                });
            }

            return itemsList;
        }

        public async Task<Item?> GetItemById(int itemId)
        {
            var item = await _context.AAC_ITEMS.FirstOrDefaultAsync(i => i.ItemId == itemId);

            if (item == null) return null;

            return new Item
            {
                ItemId = item.ItemId,
                Name = item.Name,
            };
        }

        public async Task<Item> ModifyItem(Item item)
        {
            var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted, Timeout = TimeSpan.FromSeconds(30) };
            using (var transaction = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            {
                try
                {
                    var existingItem = await _context.AAC_ITEMS.FirstOrDefaultAsync(i => i.ItemId == item.ItemId);
                    if (existingItem == null) return null;
                    existingItem.Name = item.Name;
                    existingItem.ItemId = item.ItemId;

                    await _context.SaveChangesAsync();
                    transaction.Complete();
                    return item;
                }
                catch (Exception ex)
                {
                    // Log the exception
                    return null;
                }
            }
        }
    }
}
