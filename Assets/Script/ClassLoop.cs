using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassLoop : MonoBehaviour
{
    public int[] ArrayInt = { 1, 2, 3, 4, 5, 6 };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Iterator [for]: " + i);
        }

        //int i = 0;
        //while(i < 5) {
        //    Debug.Log("Iterator [while]:" + i);
        //    i++;
        //}

        foreach( int element in ArrayInt )
        {
            Debug.Log("ArrayInt Element: " + element);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
