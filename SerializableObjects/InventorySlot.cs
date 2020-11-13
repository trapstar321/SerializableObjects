using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class InventorySlot
    {
        public int id;
        public Item item;
        public int slotID;
        public int quantity;
    }
}
