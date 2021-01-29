using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelManager LevelManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        LevelManager.CloseTrapDoor();
    }

    void OnTriggerExit2D(Collider2D other)
    {

    }
}
