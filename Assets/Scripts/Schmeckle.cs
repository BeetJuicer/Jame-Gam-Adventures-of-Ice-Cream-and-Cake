using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schmeckle : MonoBehaviour
{
    [SerializeField] GameObject pickUpEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.instance.Play("coin");
            Instantiate(pickUpEffect, transform.position, Quaternion.identity);
            Dice.score += 5;
            Destroy(gameObject);
        }
    }
}
