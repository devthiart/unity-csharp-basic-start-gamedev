using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSwitch : MonoBehaviour
{
    public int weekDay;

    // Start is called before the first frame update
    void Start()
    {
        switch(weekDay)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            case 5:
                Debug.Log("Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                break;
            case 7:
                Debug.Log("Sunday");
                break;
            default:
                Debug.Log("Day not found.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
