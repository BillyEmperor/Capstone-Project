using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_X : MonoBehaviour
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
        if (Input.GetKey(KeyCode.D) && transform.position.x < MoveMax)
        {
            transform.Translate(Vector2.right * Time.deltaTime * Speed);

        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > MoveMin)
        {
            transform.Translate(Vector2.left * Time.deltaTime * Speed);

        }
    }
}
