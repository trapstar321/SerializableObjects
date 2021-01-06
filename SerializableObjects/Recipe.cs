using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class Recipe
    {
        public int id;
        public string name;
        public float time_to_craft;
        public int experience;
        public string icon_name;
        public int item_id;
        public int skill_id;

        public List<RecipeItemRequirement> items;
        public RecipeSkillRequirement skill;
    }
}
