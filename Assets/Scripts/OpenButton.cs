using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButton : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelManager LevelManager2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
         LevelManager.OpenTrapDoor();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
    }
}
