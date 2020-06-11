using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop_Web_Application.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> AllItems { get; }
        IEnumerable<Item> ItemsOfTheWeek { get; }
        Item GetItemById(int itemId);
    }
}
