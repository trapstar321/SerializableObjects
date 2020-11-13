using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class Item
    {
        public int id;
        public int item_id;
        public string name;
        public bool isDefaultItem;
        public string iconName;
        public string item_type;
        public int attack;
        public int defence;
        public int health;
        public int rotation;
        public int speed;
        public int visibility;
        public int cannon_reload_speed;
        public int crit_chance;
        public int cannon_force;
    }
}
