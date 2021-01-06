using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class PlayerData
    {
        public int level;
        public int experience;
        public float X_SHIP;
        public float Y_SHIP;
        public float Z_SHIP;
        public float Y_ROT_SHIP;

        public float X_PLAYER;
        public float Y_PLAYER;
        public float Z_PLAYER;
        public float Y_ROT_PLAYER;

        public bool is_on_ship;

        public string username;
        public float gold;
    }
}
