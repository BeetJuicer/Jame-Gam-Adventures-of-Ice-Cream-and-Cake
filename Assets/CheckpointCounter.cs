using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCounter : MonoBehaviour
{
    bool cakePassed;
    bool iceCreamPassed;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("Checkpoint-0");
    }

    // Update is called once per frame
    void Update()
    {
        if (cakePassed && iceCreamPassed)
        {
            GameManager.GetInstance().checkPointCount++;
            cakePassed = false;
            iceCreamPassed = false;
            animator.Play("Checkpoint-2");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerHandler>().cake && !cakePassed)
            {
                cakePassed = true;
                animator.Play("Checkpoint-1-cake");
            }
            if (!collision.GetComponent<PlayerHandler>().cake && !iceCreamPassed)
            {
                iceCreamPassed = true;
                animator.Play("Checkpoint-1-iceCream");
            }
        }
    }
}
