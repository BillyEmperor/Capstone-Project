using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballHorizontalForce;
    public float ballVerticalForce;
    public Transform tf; 

    private bool isStart;
    public bool isInvincible;

    public AudioSource NormalImpact;
    public AudioSource win;
    public AudioSource lose;
    public AudioSource breaklose;

    public GameObject stars;


    // Start is called before the first frame update
    void Start()
    {
        isStart = false;
        isInvincible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                isStart = true;
                rb.AddForce(new Vector2(ballHorizontalForce, ballVerticalForce));
                ParticleSystem ps= stars.GetComponent<ParticleSystem>();
                ps.Play();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Invincible"))
        {
            isInvincible = true;
            rb.AddForce(new Vector2(2*ballHorizontalForce, 2*ballVerticalForce));
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Speed"))
        {
            ballHorizontalForce += 50;
            ballVerticalForce += 50;
            rb.AddForce(new Vector2(ballHorizontalForce, ballVerticalForce));
        }
        if(collision.CompareTag("LOSE"))
        {
            if (!isInvincible)
            {
                lose.Play();
            }
            else
            {
                breaklose.Play();
            }
        }
        if (collision.CompareTag("WIN"))
        {
            win.Play();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NormalImpact.Play();
        

    }
}
