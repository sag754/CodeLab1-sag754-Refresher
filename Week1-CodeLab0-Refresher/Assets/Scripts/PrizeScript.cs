using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrizeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //increase the player score
        collision.gameObject.GetComponent<PlayerController>().playerscore++;
        collision.gameObject.GetComponent<PlayerController>().scoreUI.text = "Score: "+collision.gameObject.GetComponent<PlayerController>().playerscore;
        transform.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));

        if(collision.gameObject.GetComponent<PlayerController>().playerscore >= 10)
        {
            SceneManager.LoadScene(1);
        }
    }
}
