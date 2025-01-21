using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using Inventory;
using Zenject;

namespace Task
{
    public class SubmitTask : MonoBehaviour
    {
        [SerializeField] private TakeTask _takeTask;
        [SerializeField] private ListTaskSo _listTaskSo;

        [SerializeField] private List<UITaskData> _uiTasks; 

        private int _maxAmountTask = 3;
        public int InStockInt = 0;

        private InventoryPanel _inventoryPanel;
        private List<InventoryCell> _slotItemData;

        [Inject]
        public void Construct(InventoryPanel InventoryPanel, List<InventoryCell> SlotItemData)
        {
            _inventoryPanel = InventoryPanel;
            _slotItemData = SlotItemData;
        }

        private void OnEnable()
        {
            SlotCheckInStock();
        }

        private void OnDisable()
        { 
            InStockInt = 0;
        }

        private void SlotCheckInStock()
        {
            foreach (var task in _uiTasks)
            {
                int _countPotionInt = int.Parse(task._countPotion.text);
                var dataCell = _slotItemData.FirstOrDefault(slot => task._itemType == slot.CurrentData.Type &&
                                                            _countPotionInt == slot.CurrentData.Count ||
                                                            task._itemType == slot.CurrentData.Type &&
                                                            _countPotionInt <= slot.CurrentData.Count);
                if (dataCell != null)
                {
                    ComparisonItems(dataCell);
                }
            }
        }
          
        private void ComparisonItems(InventoryCell cell)
        {
            var task = _listTaskSo.ListTasks[_takeTask._indexCurrentTask];
            for (int i = 0; i < task.listTasks.Count; i++)
            {
                if (task.listTasks[i].ItemTypeEnum == cell.CurrentData.Type)
                {
                    InStockInt++;
                }
            } 
        }

        public void BTM_PassTask()
        {
            if (InStockInt == _maxAmountTask)
            {
                RemoveItems(); 
                _takeTask.PlusIndexList(1);
                InStockInt = 0;
                SlotCheckInStock();
            }
        }

        private void RemoveItems()
        {
            var task = _listTaskSo.ListTasks[_takeTask._indexCurrentTask]; 

            foreach (var item in task.listTasks)
            {
                _inventoryPanel.RemoveItem(item.ItemTypeEnum, item.Count);
            }
        } 
    }
}