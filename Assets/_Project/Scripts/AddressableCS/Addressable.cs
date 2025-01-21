using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
  
public class Addressable : MonoBehaviour
{
    private GameObject _object;

    [SerializeField] private AssetReference _level;
    [SerializeField] private AssetReference _levelDesign;

    private void Awake()
    { 
        InstantiateGameobjectAssetReference(_level); 
        InstantiateGameobjectAssetReference(_levelDesign); 
    }

    public void InstantiateGameobjectAssetReference(AssetReference  key)
    {
        Addressables.InstantiateAsync(key).Completed += OnLoadDone;
    }
     
    private void OnLoadDone(AsyncOperationHandle<GameObject> obj)
    {
        _object = obj.Result;
    } 
    public void ReleseGameobject()
    {
        Addressables.Release(_object);
    }
} 