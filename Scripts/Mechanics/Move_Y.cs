using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Y : MonoBehaviour
{
    public int MoveMax;
    public int MoveMin;
    public int Speed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < MoveMax)
        {
            transform.Translate(Vector2.up * Time.deltaTime * Speed);

        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > MoveMin)
        {
            transform.Translate(Vector2.down * Time.deltaTime * Speed);

        }
    }
}
