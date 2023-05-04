using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Canva : MonoBehaviour
{
    public GameObject ShoppingUi;

    void Start()
    {
        
        ShoppingUi.gameObject.SetActive(false);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "basket")
        {
            ShoppingUi.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        ShoppingUi.gameObject.SetActive(false);
    }
}
