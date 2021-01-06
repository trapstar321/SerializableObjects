using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class GroupMember
    {
        public int playerId;
        public bool isOwner;
        public bool online;
        public int playerLvl;
        public string name;
        public float currentHealth;
        public float maxHealth;
    }
}
