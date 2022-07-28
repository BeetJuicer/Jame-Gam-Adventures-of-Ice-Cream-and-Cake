using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBody : Door
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDoorOpen)
        {
            Debug.Log("Door is Open!");
        }
    }
}
