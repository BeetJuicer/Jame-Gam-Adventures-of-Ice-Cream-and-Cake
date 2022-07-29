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
    public bool verticalDoor;
    public bool upOrRight;
    //-----------Vectors
    private Vector2 origPos;
    //-----------Values
    [HideInInspector]
    public int activeButtons;

    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.transform.parent.GetComponent<Door>();
        doorBodyEditor = gameObject.GetComponent<DoorBodyEditor>();

        if(upOrRight)
        direction = 1;
        else direction = -1;

        origPos = transform.position;
    }

    private void Update()
    {

    }

    public void OpenDoor()
    {
        if (verticalDoor)
        {
            transform.DOMoveY(origPos.y + doorBodyEditor.doorHeight * direction, 0.5f).SetEase(Ease.InOutSine);
            Debug.Log("Vertical Open");
        }
        else
        {
            transform.DOMoveX(origPos.x + doorBodyEditor.doorHeight * direction, 0.5f).SetEase(Ease.InOutSine);
        } 
    }
    public void CloseDoor()
    {
        if (verticalDoor)
        {
            transform.DOMoveY(origPos.y, 0.5f).SetEase(Ease.InOutSine);
        }
        else
        {
            transform.DOMoveX(origPos.x, 0.5f).SetEase(Ease.InOutSine);
        }
    }
}
