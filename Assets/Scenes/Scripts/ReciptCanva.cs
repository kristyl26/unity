using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciptCanva : MonoBehaviour
{
    public GameObject ReciptUi;
    private float timeToAppear =3f;
    private float timeWhenDisappear;

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
            timeWhenDisappear = Time.time + timeToAppear;
        }

    }

    void OnTriggerExit(Collider other)
    {
       
    }

    void Update()
    {
        if (ReciptUi.gameObject && (Time.time >= timeWhenDisappear))
        {
            ReciptUi.gameObject.SetActive(false);
        }
    }
}
