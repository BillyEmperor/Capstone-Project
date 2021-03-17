using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelControl: MonoBehaviour
{
    public BouncingBall ball;
    public int sceneIndex;

    public GameObject Win;
    public GameObject Lose;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            if(!ball.isInvincible || gameObject.tag == "WIN")
            {
                if (this.gameObject.tag == "LOSE")
                {
                    GameObject ob = Instantiate(Lose, collision.transform.position, Quaternion.identity) as GameObject;
                }
                if (this.gameObject.tag == "WIN")
                {
                    GameObject ob = Instantiate(Win, gameObject.transform.position, Quaternion.identity) as GameObject;
                }
                Destroy(collision.gameObject);
                StartCoroutine(WaitForSound());
                
              
            }

        
    }

    IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneIndex);
    }



}
