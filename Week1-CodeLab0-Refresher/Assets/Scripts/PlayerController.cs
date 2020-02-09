using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float force = 5;           //
    public KeyCode upkey;
    public KeyCode downkey;
    public KeyCode leftkey;
    public KeyCode rightkey;

    public int playerscore;
    public Text scoreUI;
                                      //  THIS AREA IS CALLED THE FIELD.  STARTS BELOW CLASS, ENDS AT START
    Rigidbody2D rb;                   //


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(rightkey))
        {
            rb.AddForce(Vector2.right * force);
        }

        if(Input.GetKey(upkey))
        {
            rb.AddForce(Vector2.up * force);
        }

        if (Input.GetKey(leftkey))
        {
            rb.AddForce(Vector2.right * -force);
        }

        if (Input.GetKey(downkey))
        {
            rb.AddForce(Vector2.up * -force);
        }
    }
}
