using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class Group
    {
        public int groupId;
        public string name;
        public int playerCount;
    }
}
