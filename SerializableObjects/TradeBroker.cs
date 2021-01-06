using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class TradeBroker
    {
        public int id;        
        public float x;
        public float y;
        public float z;
        public float y_rot;
        public int game_object_type;
    }
}
