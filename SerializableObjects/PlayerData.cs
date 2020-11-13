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
        public float X;
        public float Y;
        public float Z;
        public float Y_rot;
    }
}
