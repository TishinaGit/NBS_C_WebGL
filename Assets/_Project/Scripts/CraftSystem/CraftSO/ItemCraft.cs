using UnityEngine;
using System.Collections.Generic;

using Inventory;

namespace ReceiptsSystem
{
    [System.Serializable]
    public class ItemCraft
    {
        public ItemTypeEnum Type;
        public Sprite AvatarItem;
        public bool CraftTrue;
          
        public List<MaterialsForCraft> MaterialsForCraft; 
    }
}
 