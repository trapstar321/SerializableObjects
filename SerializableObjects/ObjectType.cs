using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public enum ObjectType
    {
        RESOURCE,
        TRADER,
        CHEST,
        TRADE_BROKER
    }
}
