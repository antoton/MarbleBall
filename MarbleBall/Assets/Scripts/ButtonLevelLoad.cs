﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{
    public string mLevelToLoad;
    // Start is called before the first frame update
    public void LoadLevel() {
        // Load the new Level (mLevelToLoad)
        SceneManager.LoadScene(mLevelToLoad);
    }
}
