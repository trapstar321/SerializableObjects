using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class BaseStat
    {
        public float level;
        public float attack;
        public float health;
        public float defence;
        public float rotation;
        public float speed;
        public float visibility;
        public float cannon_reload_speed;
        public float crit_chance;
        public float cannon_force;
        public float max_health;
    }
}
