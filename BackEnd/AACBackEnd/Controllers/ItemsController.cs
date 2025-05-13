using AACBackEnd.Managers;
using AACBackEnd.Models;
using AACBackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AACBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;
        private readonly IItemRepository _itemRepository;
        Managers.ItemManager _itemManager;

        public ItemsController(ILogger<ItemsController> _logger, IItemRepository itemRepository, ItemManager itemManager)
        {
            this._logger = _logger;
            _itemRepository = itemRepository;
            this._itemManager = itemManager;
        }

        [HttpGet("{itemId}")]
        public async Task<Item?> GetItemById(int itemId)
        {
            return await this._itemManager.GetItemById(itemId);
        }

        [HttpGet]
        public async Task<List<Item>> GetAllItems()
        {
            return await this._itemManager.GetAllItems();
        }

        [HttpPost]
        public async Task<Item> AddItem([FromBody] Item item)
        {
            return await this._itemManager.AddItem(item);
        }

        [HttpPut]
        public async Task<Item> ModifyItem([FromBody] Item item)
        {
            return await this._itemManager.ModifyItem(item);
        }

        //[HttpDelete("{itemId")]
        //public async Task<bool> DeleteItem(int id)
        //{
        //    return await this._itemManager.DeleteItem(id);
        //}
    }
}
