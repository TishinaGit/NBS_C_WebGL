using UnityEngine.UI;

using Inventory;

namespace ReceiptsSystem
{
    public class UIDataReceipts : BTNÑooldown
    {
        public ItemTypeEnum ItemType;

        public Image SpriteItem;
        public Image SpriteMaterial_1;
        public Image SpriteMaterial_2;
        public Image SpriteMaterial_3;

        public Button Button;
         
        private void Awake()
        {
            Button.enabled = false;
        } 
    }
} 