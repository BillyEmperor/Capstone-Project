using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 20f;
    [SerializeField] Text timerText;
    public int nextLevel;
    bool isStart = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isStart = true;
        }

        if (isStart)
        {
            currentTime -= 1 * Time.deltaTime;
            if (currentTime < 10)
            {
                timerText.text = "00:0" + currentTime.ToString("0");
            }
            else
            {
                timerText.text = "00:" + currentTime.ToString("0");
            }
            
            
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(nextLevel);
        }
        

    }
}
