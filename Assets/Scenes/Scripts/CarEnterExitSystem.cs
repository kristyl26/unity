using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnterExitSystem : MonoBehaviour
{

    public MonoBehaviour CarController;
    public Transform Car;
    public Transform Player;

    [Header("Cameras")]
    public GameObject PlayerCam;
    public GameObject CarCam;

    public GameObject DriveUi;

    bool Candrive;
  

    // Start is called before the first frame update
    void Start()
    {
        CarController.enabled = false;
        DriveUi.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.F) && Candrive)
        {
            CarController.enabled = true;

            DriveUi.gameObject.SetActive(false);

          
            Player.transform.SetParent(Car);
            Player.gameObject.SetActive(false);

            //camera
            PlayerCam.gameObject.SetActive(false);
            CarCam.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
     
            CarController.enabled = false;
            Player.transform.SetParent(null);
            Player.gameObject.SetActive(true);

            //camera
            PlayerCam.gameObject.SetActive(true);
            CarCam.gameObject.SetActive(false);
        }
           
        

    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            DriveUi.gameObject.SetActive(true);
            Candrive = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            
            Candrive = false;
        }
    }
}
