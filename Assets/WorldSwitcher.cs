using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject iceCreamGround;
    [SerializeField] private GameObject cakeGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cakeGround.SetActive(GameManager.isCake);
        iceCreamGround.SetActive(!GameManager.isCake);
    }
}
