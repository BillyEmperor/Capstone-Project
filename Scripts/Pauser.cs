using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauser : MonoBehaviour
{
    bool isStop = false;
    public Canvas PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isStop = !isStop;
        }
        if(isStop)
        {
            Time.timeScale = 0;
            PauseMenu.enabled = true;
        }
        else
        {
            Time.timeScale = 1;
            PauseMenu.enabled = false;
        }
    }
}
