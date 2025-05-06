using AACBackEnd.Models;
using AACBackEnd.Repositories;

namespace AACBackEnd.Managers
{
    public class ItemManager : BaseManager
    {
        private readonly IItemRepository _itemService;
        public ItemManager(IItemRepository itemService)
        {
            this._itemService = itemService;
        }
        public async Task<Item?> GetItemById(int itemId)
        {
            return await this._itemService.GetItemById(itemId);
        }
        public async Task<List<Item>> GetAllItems()
        {
            return await this._itemService.GetAllItems();
        }
        public async Task<Item> AddItem(Item item)
        {
            return await this._itemService.AddItem(item);
        }
        public async Task<Item> ModifyItem(Item item)
        {
            return await this._itemService.ModifyItem(item);
        }

        // Zeddy said to delete this. Im keeping it!

        //public async Task<bool> DeleteItem(int id)
        //{
        //    return await this._itemService?.DeleteItem(id);
        //}
    }
}
