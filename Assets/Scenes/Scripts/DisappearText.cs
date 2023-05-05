using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearText : MonoBehaviour
{
    public GameObject infoText;
    private float timeToAppear = 3f;
    private float timeWhenDisappear;

    // Start is called before the first frame update
    void Start()
    {
        infoText.gameObject.SetActive(true);
        timeWhenDisappear = Time.time + timeToAppear;
    }

    // Update is called once per frame
    void Update()
    {
        if (infoText.gameObject && (Time.time >= timeWhenDisappear))
        {
            infoText.gameObject.SetActive(false);
        }
    }
}
