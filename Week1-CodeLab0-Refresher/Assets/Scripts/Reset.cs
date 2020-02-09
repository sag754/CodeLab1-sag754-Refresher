using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("restart", 5);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void restart()
    {
        SceneManager.LoadScene(0);
    }
}
