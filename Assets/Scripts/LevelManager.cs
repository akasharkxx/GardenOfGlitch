﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float autoLoadNextLevelAfter;

    void Start() {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void LoadLevel(string name){
        Debug.Log("Level load requested for: " + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void LoadNextLevel(){
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}