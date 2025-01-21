using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

public class AddressableGameScene : MonoBehaviour
{
    private void Awake()
    {
        Addressables.LoadResourceLocationsAsync("GameScene_Texture", typeof(Texture2D)).Completed += LoadResourceAsync;
        Addressables.LoadResourceLocationsAsync("GameScene_Texture", typeof(Texture)).Completed += LoadResourceAsync;
        Addressables.LoadResourceLocationsAsync("GameScene_Texture", typeof(Sprite)).Completed += LoadResourceAsync;

        Addressables.LoadResourceLocationsAsync("GameScene_Material", typeof(Material)).Completed += LoadResourceAsync;
        Addressables.LoadResourceLocationsAsync("GameScene_Material", typeof(Shader)).Completed += LoadResourceAsync;

        Addressables.LoadResourceLocationsAsync("GameScene_Mesh", typeof(Mesh)).Completed += LoadResourceAsync;
        Addressables.LoadResourceLocationsAsync("GameScene_Mesh", typeof(GameObject)).Completed += LoadResourceAsync;

        Addressables.LoadResourceLocationsAsync("GameScene_Gameobject", typeof(GameObject)).Completed += LoadResourceAsync; 
    }

    private void LoadResourceAsync(AsyncOperationHandle<IList<IResourceLocation>> obj)
    {
        foreach (var resource in obj.Result)
        {
            Debug.Log(resource.PrimaryKey);
            Debug.Log(resource.ResourceType);
        }
    }
}
