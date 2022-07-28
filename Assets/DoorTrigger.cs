using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private Door door;
    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.transform.parent.GetComponent<Door>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerHandler>().cake)
            {
                door.isDoorOpen = true;
                Debug.Log("Trigger detected cake");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerHandler>().cake)
            {
                door.isDoorOpen = false;
                Debug.Log("Cake has exited trigger");
            }
        }
    }
}
