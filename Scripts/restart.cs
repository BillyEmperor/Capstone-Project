﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour

    
{
    // Start is called before the first frame update
    public int thisScene;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
    {
        SceneManager.LoadScene(thisScene+1);
    }
    }
}