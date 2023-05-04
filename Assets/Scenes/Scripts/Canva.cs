using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Canva : MonoBehaviour
{
    public GameObject ShoppingUi;
    public GameObject ReciptUi;

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
      
    }

    
}
