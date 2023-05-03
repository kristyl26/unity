using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider wall)
    {
        if (wall.tag == "wall")
        {
            Debug.Log("Trigger activated");
            SceneManager.LoadScene("s2", LoadSceneMode.Single);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
