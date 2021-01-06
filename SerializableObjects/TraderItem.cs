using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class TraderItem
    {
        public int item_id;
        public Item item;
        public int quantity;
        public int inventory_quantity;
        public float sell_price;
        public float buy_price;
    }
}
