using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPickingUp : MonoBehaviour
{
    public GameObject BuyUi;
    public GameObject PreviousUi;
    // Start is called before the first frame update
    void Start()
    {
        BuyUi.gameObject.SetActive(false);
        Destroy(PreviousUi);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BuyUi.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        
    }
}
