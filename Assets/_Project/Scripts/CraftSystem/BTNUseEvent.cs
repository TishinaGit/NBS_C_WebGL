using System.Collections.Generic; 
using UnityEngine;

using Inventory;
using Zenject;
using System;

namespace ReceiptsSystem
{
    public class BTNUseEvent : BTNÑooldown
    {
        [SerializeField] private ItemCraftList _itemCraftList;
        [SerializeField] private List<UIDataReceipts> _uiDataReceipts = new(); 

        private InventoryPanel _inventoryPanel;
        [Inject] public void Construct(InventoryPanel inventoryPanel)
        {
            _inventoryPanel = inventoryPanel;
        }

        private void OnEnable()
        {
            CheckMaterialForCraft.CheckBTN += BTNCheck; 
        }

        private void OnDisable()
        {
            CheckMaterialForCraft.CheckBTN -= BTNCheck;
        }

        private void Start()
        {
            BTNCheck();
        }
         
        public void BTNCheck()
        {
            for (int i = 0; i < _itemCraftList.CraftList.Count; i++)
            {
                if (_itemCraftList.CraftList[i].CraftTrue == true)
                {
                    _uiDataReceipts[i].Button.enabled = true;
                }
                else
                {
                    _uiDataReceipts[i].Button.enabled = false;
                }
            }
        }

        public override void BTN_Ñooldown()
        {  
            foreach (var item in _uiDataReceipts)
            {
                if (item.isClick == true)
                {
                    var ItemType = item.ItemType;
                    RemoveItem(ItemType);
                }
            }
            base.BTN_Ñooldown(); 
        }
         
        public void RemoveItem(ItemTypeEnum itemType)
        {
            foreach (var materials in _itemCraftList.CraftList)
            {
                foreach (var material in materials.MaterialsForCraft)
                {
                    if (itemType == materials.Type)
                    {
                        _inventoryPanel.RemoveItem(material.ItemType, 1);
                    }
                }
            }
        }
    } 
}
