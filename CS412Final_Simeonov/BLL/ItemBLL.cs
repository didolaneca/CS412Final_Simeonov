using CS412Final_Simeonov.BLL.Interfaces;
using CS412Final_Simeonov.Models;
using CS412Final_Simeonov.Repository;
using CS412Final_Simeonov.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.BLL
{
    public class ItemBLL : IItemBLL
    {
        private readonly IItemRepository itemRepository;
        private readonly static IError error = new Error();

        public ItemBLL() {
            this.itemRepository = new ItemRepository();
        }
        public bool AddNewItem(Item item)
        {
            try {
                Item savedItem = itemRepository.saveItem(item);
                if (savedItem.Images != null) {
                    foreach (Image img in savedItem.Images) {
                        itemRepository.saveImage(img);
                    }
                    
                }
            }
            catch (Exception ex) {

                error.Log(ex);
                return false;
            }
            return true;
        }

        public bool DeleteItem(Item item)
        {
            return itemRepository.removeItem(item);
        }

        public Item FindItemById(long id)
        {
            return itemRepository.findItemById(id);
        }

        public List<Item> GetAllItems()
        {
            return itemRepository.getAllItems();
        }

        public bool UpdateItem(Item item)
        {
            try
            {
                itemRepository.updateItem(item);
            }
            catch (Exception ex)
            {

                error.Log(ex);
                return false;
            }
            return true;
        }
    }
}