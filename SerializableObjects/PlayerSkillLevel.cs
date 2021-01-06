using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class PlayerSkillLevel
    {
        public int id;
        public int skill_id;
        public string name;
        public int level;
        public int modifier;
        public int experience_start;
        public int experience_end;
        public int experience;
    }
}
