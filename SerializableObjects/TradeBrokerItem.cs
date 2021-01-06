using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class TradeBrokerItem
    {
        public int id;
        public Item item;
        public int quantity;
        public float price;
        public string seller;
    }
}
