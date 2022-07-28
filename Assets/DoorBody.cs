using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DoorBody : MonoBehaviour
{
    private Door door;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.transform.parent.GetComponent<Door>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (door.isDoorOpen)
        {
            Debug.Log("Door is Open!");
        }

        boxCollider.size = spriteRenderer.size;
        float colliderOffsetY = -boxCollider.size.y / 2;
        boxCollider.offset = new Vector2(0f, colliderOffsetY);
    }
}
