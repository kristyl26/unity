using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciptCanva : MonoBehaviour
{
    public GameObject ReciptUi;
    // Start is called before the first frame update
    void Start()
    {
        ReciptUi.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "payment")
        {
            ReciptUi.gameObject.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
