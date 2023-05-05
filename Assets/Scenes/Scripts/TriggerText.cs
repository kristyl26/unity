using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject DestroyText;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        Destroy(DestroyText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
