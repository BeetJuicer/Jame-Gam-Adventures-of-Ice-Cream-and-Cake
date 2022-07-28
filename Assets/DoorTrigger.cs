using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorTrigger : MonoBehaviour
{
    private Door door;

    [SerializeField]
    private DoorBody doorBody;

    [SerializeField]
    private bool cakeTrigger;

    private Vector3 startPosition;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.transform.parent.GetComponent<Door>();
        startPosition = transform.position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("cake", cakeTrigger);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (cakeTrigger && collision.GetComponent<PlayerHandler>().cake)
            {
                transform.DOMoveY(startPosition.y - 0.25f, 0.2f).SetEase(Ease.InOutSine);
                doorBody.OpenDoor();
            }
            if (!cakeTrigger && !collision.GetComponent<PlayerHandler>().cake)
            {
                transform.DOMoveY(startPosition.y - 0.25f, 0.2f).SetEase(Ease.InOutSine);
                doorBody.OpenDoor();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (cakeTrigger && collision.GetComponent<PlayerHandler>().cake)
            {
                transform.DOMoveY(startPosition.y, 0.2f).SetEase(Ease.InOutSine);
                doorBody.CloseDoor();
            }
            if (!cakeTrigger && !collision.GetComponent<PlayerHandler>().cake)
            {
                transform.DOMoveY(startPosition.y - 0.25f, 0.2f).SetEase(Ease.InOutSine);
                doorBody.OpenDoor();
            }
        }
    }
}
