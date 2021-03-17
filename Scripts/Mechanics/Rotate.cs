using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.Rotate(0, 0, 90);
            GetComponent<AudioSource>().Play();
        }
    }
}
