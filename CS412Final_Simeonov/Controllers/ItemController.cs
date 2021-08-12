using CS412Final_Simeonov.BLL;
using CS412Final_Simeonov.BLL.Interfaces;
using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CS412Final_Simeonov.Controllers
{
    [RoutePrefix("api/items")]
    public class ItemController : ApiController
    {
        private readonly IItemBLL itemBLL;

        public ItemController() {
            this.itemBLL = new ItemBLL();
        }

        [HttpGet]
        [Route("")]
        public List<Item> GetAllItems() => itemBLL.GetAllItems();

        [HttpGet]
        [Route("{id}")]
        public Item GetItemById(long id)
        {
            return itemBLL.FindItemById(id);
        }

        [HttpPost]
        [Route("addItem")]
        public HttpResponseMessage saveItem(ItemRequest itemRequest)
        {
            if (itemBLL.AddNewItem(itemRequest.Item)) {
                return Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError, "Could not save the item");
        }

        [HttpPut]
        [Route("updateItem")]
        public HttpResponseMessage updateItem(ItemRequest itemRequest)
        {
            if (itemBLL.UpdateItem(itemRequest.Item))
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError, "Could not update the item");
        }

        [HttpDelete]
        [Route("deleteItem")]
        public HttpResponseMessage deleteItem(ItemRequest itemRequest)
        {
            if (itemBLL.DeleteItem(itemRequest.Item))
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError, "Could not delete the item");
        }
    }
}