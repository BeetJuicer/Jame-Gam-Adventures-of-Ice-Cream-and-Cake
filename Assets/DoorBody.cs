using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorBody : MonoBehaviour
{
    //----Components

    //-----------Scripts
    private Door door;
    private DoorBodyEditor doorBodyEditor;
    //-----------Bools

    //-----------Vectors
    private Vector2 topPosition;
    private Vector2 bottomPosition;
    private Vector2 origPos;

    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.transform.parent.GetComponent<Door>();
        doorBodyEditor = gameObject.GetComponent<DoorBodyEditor>();

        origPos = transform.position;
    }

    private void Update()
    {
        Debug.Log("Top Position: " + topPosition + " Bottom Position: " + bottomPosition);
    }

    public void OpenDoor()
    {
        transform.DOMoveY(origPos.y + doorBodyEditor.doorHeight, 1.5f).SetEase(Ease.InOutSine);
    }
    public void CloseDoor()
    {
        transform.DOMoveY(origPos.y, 1.5f).SetEase(Ease.InOutSine);
    }
}
