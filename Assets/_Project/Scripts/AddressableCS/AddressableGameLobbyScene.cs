using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets; 
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

[Serializable]
public class AssetReferenceAudioClip : AssetReferenceT<AudioClip>
{
    public AssetReferenceAudioClip(string guid) : base(guid) { }
}

[Serializable]
public class AssetReferenceAudioSource : AssetReferenceT<AudioSource>
{
    public AssetReferenceAudioSource(string guid) : base(guid) { }
}

public class AddressableGameLobbyScene : MonoBehaviour
{
    private void Awake()
    {
        //Addressables.LoadResourceLocationsAsync("Json", typeof(TextAsset)).Completed += LoadResourceAsync;  
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
