using UnityEngine;

using Inventory;

namespace ReceiptsSystem
{
    [System.Serializable]
    public class MaterialsForCraft
    {
        public ItemTypeEnum ItemType;
        public Sprite Sprite;
        public int Count;
        public bool InStock;
    } 
}
