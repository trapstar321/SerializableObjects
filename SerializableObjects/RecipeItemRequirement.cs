using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableObjects
{
    [Serializable]
    public class RecipeItemRequirement
    {
        public int id;
        public int item_id;
        public string item_name;
        public string icon_name;
        public int quantity;
    }
}
