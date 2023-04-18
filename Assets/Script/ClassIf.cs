using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassIf : MonoBehaviour
{
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        if ( isAlive == true )
        {
            Debug.Log("Alive");
        } 
        else
        {
            Debug.Log("Dead");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space) )
        {
            Debug.Log("Space Pressed.");
        }
    }
}
