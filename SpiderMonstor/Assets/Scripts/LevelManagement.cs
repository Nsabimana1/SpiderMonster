using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour
{
    public string levelName;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelName);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
