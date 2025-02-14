﻿using Data;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EntryPoint
{
    public class GameInstance : MonoBehaviour
    {
        
        private void Awake()
        {
            DontDestroyOnLoad(this);
            SetTargetFPS(); 
            LoadGameScene();
            
        }

        private void SetTargetFPS()
        {
            Application.targetFrameRate = 60;
        }

        private void Init()
        { 
        }

        private void LoadGameScene()
        {
            RunGame();
        }

        private void RunGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}
