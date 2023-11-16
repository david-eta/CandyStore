using CSharpestServer.Classes;
using Microsoft.AspNetCore.Mvc;

namespace CSharpestServer.Services
{
    public class ItemService
    {
        InventoryLoader inventoryLoader = new InventoryLoader(@".\data\inventory.json");

        public ItemService ()
        {

        }
        public SortedSet<Item> GetAllItems()
        {
            SortedSet<Item> items = inventoryLoader.loadInventorySorted();
            return items;
        }
    }
}
