﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    public string SceneName;
    public void changeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    
}
