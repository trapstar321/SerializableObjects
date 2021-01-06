using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class RecipeSkillRequirement
    {
        public int skill_level_id;
        public string skill_name;
        public int level;
        public int modifier;
    }
}
