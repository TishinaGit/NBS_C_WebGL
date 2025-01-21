using Cinemachine;
using Controller;
using Inventory;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class GameSceneContextIn : MonoInstaller
{
    public Transform TransformCamera;
    public CinemachineFreeLook CinemachineFreeLook; 
    public GameObject PlayerPrefab;
    public GameObject AimTargetForCamera;
    public Camera CameraPlayer;
    
    public AddSpriteForItem AddSpriteForItem;
    public List<InventoryCell> InventoryCells; 
    public List<GameObject> ItemsData;
    public InventoryPanel InventoryPanel;
    public Collider ColliderPlayer;
    public TMP_Text UIScoreText;
    public DataAddItems _dataAddItems;
    public Entity EnemyPrefab;
    public EventDeathPlayer EventDeathPlayer;

    public override void InstallBindings()
    {  
        PlayerCamera();

        CameraAimTarget();
          
        CameraTransform();

        CinemachineFreeLookForCanvas(); 
         
        AddSpriteItem();

        ListInventoryCell();

        ListGameObjectsInventoryCells();

        EventDeathPlayerObject(); 

        Player(); 

        InventoryPanelGameScene();

        PlayerCollider();

        UITextScore();

        DataAddItem();

        EnemyObject(); 
    }

     
    public void PlayerCamera()
    {
        Container.Bind<Camera>().FromInstance(CameraPlayer).AsSingle();
    }
    public void CameraAimTarget()
    {
        Container.Bind<GameObject>().FromInstance(AimTargetForCamera).AsSingle();
    }
    public void CameraTransform()
    {
        Container.Bind<Transform>().FromInstance(TransformCamera).AsSingle();
    }
    public void CinemachineFreeLookForCanvas()
    {
        Container.Bind<CinemachineFreeLook>().FromInstance(CinemachineFreeLook).AsSingle();
    }  
    public void AddSpriteItem()
    {
        Container.Bind<AddSpriteForItem>().FromInstance(AddSpriteForItem).AsSingle();
    }
    public void ListInventoryCell()
    {
        Container.Bind<List<InventoryCell>>().FromInstance(InventoryCells).AsSingle();
    } 
    public void ListGameObjectsInventoryCells()
    {
        Container.Bind<List<GameObject>>().FromInstance(ItemsData).AsSingle();
    } 
    public void Player()
    {
        PlayerController playerController = Container.InstantiatePrefabForComponent<PlayerController>(PlayerPrefab);
        Container.Bind<PlayerController>().FromInstance(playerController).AsSingle();
    }
    public void InventoryPanelGameScene()
    {
        Container.Bind<InventoryPanel>().FromInstance(InventoryPanel).AsSingle();
    } 
    public void PlayerCollider()
    {
        Container.Bind<Collider> ().FromInstance(ColliderPlayer).AsSingle();
    } 
    public void UITextScore()
    {
        Container.Bind<TMP_Text>().FromInstance(UIScoreText).AsSingle();
    } 
    public void DataAddItem()
    {
          Container.Bind<DataAddItems>().FromInstance(_dataAddItems).AsSingle(); 
    } 
    public void EnemyObject()
    {
        Container.Bind<Entity>().FromInstance(EnemyPrefab).AsSingle();
    }
    public void EventDeathPlayerObject()
    {
        Container.Bind<EventDeathPlayer>().FromInstance(EventDeathPlayer).AsSingle().NonLazy();
    }
} 
