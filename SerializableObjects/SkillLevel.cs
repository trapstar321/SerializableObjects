using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class SkillLevel
    {
        public int skill_level_id;
        public SkillType skill;
        public int level;
        public int modifier;
        public int experienceStart;
        public int experienceEnd;
        public string skillName;
        public string icon;
    }
}
