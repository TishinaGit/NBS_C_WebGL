using Inventory;
using UnityEngine;
using Zenject;

public class DataAddItems : MonoBehaviour
{
    public InventoryPanel _inventoryPanel; 
     
    [Inject]
    public void Construct(InventoryPanel InventoryPanel)
    {
        _inventoryPanel = InventoryPanel;
    }
    
    public void AddNone()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.None, 0, 0);
    }
    public void AddPotion_0()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.Potion_0, 1, 1);
    }
    public void AddPotion_1()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.Potion_1, 1, 2);
    }
    public void AddPotion_2()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.Potion_2, 1, 3);
    }
    public void AddPotionWB_0()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.PotionWB_0, 1, 4);
    }
    public void AddPotionWB_1()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.PotionWB_1, 1, 5);
    }
    public void AddPotionWB_2()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.PotionWB_2, 1, 6);
    }
    public void AddBluePotion_0()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.BluePotion_0, 1, 7);
    }
    public void AddBluePotion_1()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.BluePotion_1, 1, 8);
    }
    public void AddBluePotion_2()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.BluePotion_2, 1, 9);
    }
    public void AddRedPotion_0()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.RedPotion_0, 1, 10);
    }
    public void AddRedPotion_1()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.RedPotion_1, 1, 11);
    }
    public void AddRedPotion_2()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.RedPotion_2, 1, 12);
    }
    public void AddBlood()
    {
        _inventoryPanel.AddItem(ItemTypeEnum.Blood, 1, 13);
    }
}