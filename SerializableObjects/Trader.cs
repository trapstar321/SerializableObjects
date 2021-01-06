using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class Trader
    {
        public int id;
        public string name;
        public float x;
        public float y;
        public float z;
        public float y_rot;
        public float item_respawn_time;
        public int game_object_type;
        public List<TraderItem> inventory;
        public DateTime respawned = DateTime.Now;
    }
}
