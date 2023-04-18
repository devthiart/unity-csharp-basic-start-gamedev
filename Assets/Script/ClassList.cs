using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassList : MonoBehaviour
{
    public List<int> age = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        age.Add(1);
        age.Add(2);
        age.Add(3);

        foreach (int item in age)
        {
            Debug.Log("Age Item: " + item);
        }

        age.Remove(1);

        age.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
