using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorTrigger : MonoBehaviour
{
    private Door door;

    [SerializeField]
    private DoorBody doorBody;

    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.transform.parent.GetComponent<Door>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Door Open: " + door.isDoorOpen);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerHandler>().cake)
            {
                Debug.Log("Opening door.");
                transform.DOMoveY(startPosition.y - 0.25f, 0.2f).SetEase(Ease.InOutSine);
                doorBody.OpenDoor();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerHandler>().cake)
            {
                Debug.Log("Closing door.");
                transform.DOMoveY(startPosition.y, 0.2f).SetEase(Ease.InOutSine);
                doorBody.CloseDoor();
            }
        }
    }
}
