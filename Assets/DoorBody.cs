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
    public bool doorBodyOpened;
    //-----------Vectors
    private Vector2 topPosition;
    private Vector2 bottomPosition;
    private Vector2 origPos;
    //-----------Values
    public int activeButtons;

    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.transform.parent.GetComponent<Door>();
        doorBodyEditor = gameObject.GetComponent<DoorBodyEditor>();

        origPos = transform.position;
    }

    private void Update()
    {
        if (transform.position.y == origPos.y + doorBodyEditor.doorHeight)
        {
            doorBodyOpened = true;
        }
        else
        {
            doorBodyOpened = false;
        }
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
