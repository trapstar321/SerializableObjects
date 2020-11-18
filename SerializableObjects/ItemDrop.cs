using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class ItemDrop
    {
        public Item item;
        public int quantity;
    }
}
