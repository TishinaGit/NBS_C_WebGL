using UnityEngine;
using System.Linq;
using System.Collections.Generic;

using Zenject;
using Inventory;

namespace ReceiptsSystem
{
    public class CheckMaterialForCraft : MonoBehaviour
    {
        [SerializeField] private ItemCraftList _itemCraftList; 

        private List<InventoryCell> _inventoryCells;

        public static event System.Action CheckBTN;

        [Inject]
        public void Construct(List<InventoryCell> inventoryCells)
        {
            _inventoryCells = inventoryCells;
        }

        private void OnEnable()
        { 
            CheckMaterialInCells(); 
        }

        public void CheckMaterialInCells()
        {
            foreach (var item in _itemCraftList.CraftList)
            {
                foreach (var materials in item.MaterialsForCraft)
                {
                    materials.InStock = false;

                    var dataCell = _inventoryCells.FirstOrDefault(cell =>
                                   cell.CurrentData.Type == materials.ItemType &&
                                   cell.CurrentData.Count >= materials.Count);

                    if (dataCell != null)
                    {
                        materials.InStock = true; 

                    }
                    CheckStateCraft(item); 
                }
            }
        }

        private void CheckStateCraft(ItemCraft item)
        {
            item.CraftTrue = false;

            var itemTrue = item.MaterialsForCraft.All(item =>
                                   item.InStock == true);

            if (itemTrue == true)
            {
                item.CraftTrue = true;
                CheckBTN?.Invoke(); 
            } 
        }
    }
}

