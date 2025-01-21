using Cinemachine;
using Controller;
using Inventory;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
 
public class GameLobbySceneInstaller : MonoInstaller
{
    public List<Canvas> AllLabCanvas; 
    public Canvas CanvasActionEText; 
    public Image UiWaterScales;
    public Transform TransformCamera;
    public GameObject AimTargetForCamera;
    public GameObject PlayerPrefab;
    public AddSpriteForItem AddSpriteForItem; 
    public InventoryPanel InventoryPanel; 
    public CinemachineFreeLook CinemachineFreeLook;
    public DataAddItems DataAddItems;
    public List<GameObject> ItemsData;
    public List<InventoryCell> InventoryCells;
    
     
    public override void InstallBindings()
    {
        AllLabCanvasObject(); 

        CanvasActionETextObject(); 

        UiWaterScalesImage();

        CameraTransform();

        CameraAimTarget();

        CinemachineFreeLookForCanvas();

        Player();

        AddSpriteItem();

        InventoryPanelGameScene();

        DataAddItemsObjectCS();

        ListInventoryCell();
        
        ListGameObjectsInventoryCells(); 
    }

    public void AllLabCanvasObject()
    {
        Container.Bind<List<Canvas>>().FromInstance(AllLabCanvas).AsSingle();
    } 

    public void CanvasActionETextObject()
    {
        Container.Bind<Canvas>().FromInstance(CanvasActionEText).AsSingle();
    }

    public void CameraTransform()
    {
        Container.Bind<Transform>().FromInstance(TransformCamera).AsSingle();
    } 

    public void UiWaterScalesImage()
    {
        Container.Bind<Image>().FromInstance(UiWaterScales).AsSingle();
    }

    public void CameraAimTarget()
    {
        Container.Bind<GameObject>().FromInstance(AimTargetForCamera).AsSingle();
    }

    public void CinemachineFreeLookForCanvas()
    {
        Container.Bind<CinemachineFreeLook>().FromInstance(CinemachineFreeLook).AsSingle();
    }

    public void Player()
    {
        PlayerController playerController = Container.InstantiatePrefabForComponent<PlayerController>(PlayerPrefab);
        Container.Bind<PlayerController>().FromInstance(playerController).AsSingle(); 
    }
     
    public void AddSpriteItem()
    {
        Container.Bind<AddSpriteForItem>().FromInstance(AddSpriteForItem).AsSingle(); 
    }

    public void InventoryPanelGameScene()
    {
        Container.Bind<InventoryPanel>().FromInstance(InventoryPanel).AsSingle();
    }
    
    public void DataAddItemsObjectCS()
    {
        Container.Bind<DataAddItems>().FromInstance(DataAddItems).AsSingle();
    }

    public void ListInventoryCell()
    {
        Container.Bind<List<InventoryCell>>().FromInstance(InventoryCells).AsSingle(); 
    }

    public void ListGameObjectsInventoryCells()
    {
        Container.Bind<List<GameObject>>().FromInstance(ItemsData).AsSingle();
    } 
}   