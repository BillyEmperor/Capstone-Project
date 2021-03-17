using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    public bool show;
    public Color whenOn;
    public Color whenOff;
    // Start is called before the first frame update
    void Start()
    {
        if (show)
        {
            transform.GetComponent<Collider2D>().enabled = true;
            transform.GetComponent<SpriteRenderer>().material.color = whenOn;
        }
        else
        {
            transform.GetComponent<Collider2D>().enabled = false;
            transform.GetComponent<SpriteRenderer>().material.color = whenOff;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.GetComponent<Collider2D>().isActiveAndEnabled && Input.GetKeyDown(KeyCode.J))
        {
            transform.GetComponent<Collider2D>().enabled = false;
            transform.GetComponent<SpriteRenderer>().material.color = whenOff;
            GetComponent<AudioSource>().Play();
        }
        else if (!transform.GetComponent<Collider2D>().isActiveAndEnabled && Input.GetKeyDown(KeyCode.J))
        {
            transform.GetComponent<Collider2D>().enabled = true;
            transform.GetComponent<SpriteRenderer>().material.color = whenOn;
            GetComponent<AudioSource>().Play();
        }
    }




}

