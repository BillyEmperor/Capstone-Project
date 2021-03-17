using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDie : MonoBehaviour
{
    public BouncingBall ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            if (ball.isInvincible)
            {
                Destroy(gameObject);
            }
    }
}
