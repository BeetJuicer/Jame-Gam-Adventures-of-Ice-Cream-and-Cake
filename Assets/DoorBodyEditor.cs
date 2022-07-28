using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DoorBodyEditor : MonoBehaviour
{
    //----Components
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;
    //----GameObjects
    [SerializeField]
    private GameObject doorTrigger;
    //----Floats
    public float doorHeight;
    private float doorWidth = 0.8125f;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.size = new Vector2(doorWidth, doorHeight);

        boxCollider.size = spriteRenderer.size;
        float colliderOffsetY = -boxCollider.size.y / 2;
        boxCollider.offset = new Vector2(0f, colliderOffsetY);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, doorTrigger.transform.position);
    }

    

}
