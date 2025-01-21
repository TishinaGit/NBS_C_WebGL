using System.Collections.Generic;  
using UnityEngine;

namespace ReceiptsSystem
{
    public class GiveSprite : MonoBehaviour
    { 
        [SerializeField] private ItemCraftList _itemCraftList;
        [SerializeField] private List<UIDataReceipts> _uiDataReceipts = new();

        private void Awake()
        {
            SpriteGive();
        }

        private void SpriteGive()
        {
            var indexMaterial = 3;
            for (int i = 0; i < _itemCraftList.CraftList.Count; i++)
            { 
                if (i >= _itemCraftList.CraftList.Count)
                {
                    return;
                }
                else
                {
                    _uiDataReceipts[i].SpriteItem.sprite = _itemCraftList.CraftList[i].AvatarItem;
                    _uiDataReceipts[i].SpriteMaterial_1.sprite = _itemCraftList.CraftList[i].MaterialsForCraft[0].Sprite;
                    _uiDataReceipts[i].SpriteMaterial_2.sprite = _itemCraftList.CraftList[i].MaterialsForCraft[1].Sprite;
                    if (_itemCraftList.CraftList[i].MaterialsForCraft.Count >= indexMaterial)
                    {
                        _uiDataReceipts[i].SpriteMaterial_3.sprite = _itemCraftList.CraftList[i].MaterialsForCraft[2].Sprite;
                    }
                } 
            }
        }
    }
}
