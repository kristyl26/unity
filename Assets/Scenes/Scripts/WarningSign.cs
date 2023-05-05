using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningSign : MonoBehaviour
{
    public GameObject WarningUi;

    // Start is called before the first frame update
    void Start()
    {
        WarningUi.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WarningUi.gameObject.SetActive(true);
        }

    }

  void OnTriggerExit(Collider other)
    {
        
    }
}
