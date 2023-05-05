using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    public GameObject TextUi;
    private float timeToAppear = 3f;
    private float timeWhenDisappear;

    // Start is called before the first frame update
    void Start()
    {
        TextUi.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TextUi.gameObject.SetActive(true);
            timeWhenDisappear = Time.time + timeToAppear;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
    }

    void Update()
    {
        if (TextUi.gameObject && (Time.time >= timeWhenDisappear))
        {
            TextUi.gameObject.SetActive(false);

        }
    }
}
