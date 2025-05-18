using AACBackEnd.Models.Items;

namespace AACBackEnd.Repositories.Items
{
    public interface IItemRepository
    {
        Task<Item?> GetItemById(int id);
        Task<List<Item>> GetAllItems(); // not sure if this is needed
        Task<Item> AddItem(Item item);
        Task<Item> ModifyItem(Item item);
        //Task<bool> DeleteItem(int id); revisit this later!!!
    }
}
