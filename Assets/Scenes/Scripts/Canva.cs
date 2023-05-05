using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Canva : MonoBehaviour
{
    public GameObject ShoppingUi;
    public GameObject shopUi;
   

    void Start()
    {
        
        ShoppingUi.gameObject.SetActive(false);
        shopUi.gameObject.SetActive(false);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ppl")
        {
            shopUi.gameObject.SetActive(true);
           

        }

        else if (other.gameObject.tag == "basket")
        {
            ShoppingUi.gameObject.SetActive(true);
            Destroy(shopUi);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "payment")
        {
            ShoppingUi.gameObject.SetActive(false);
            
        }
    }

    
}
