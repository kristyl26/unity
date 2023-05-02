using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    public GameObject myHands;
    bool canpickup;
    GameObject ObjectIwantToPickUp;
    bool hasItem;
    // Start is called before the first frame update
    void Start()
    {
        canpickup= false;
        hasItem=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canpickup==true)
        {
            if (Input.GetKeyDown("e"))
            {
                ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic=false;
                ObjectIwantToPickUp.transform.position=myHands.transform.position;
                ObjectIwantToPickUp.transform.parent=myHands.transform;

                hasItem=true;

            }
        }
            if (Input.GetButtonDown("q")&&hasItem==true)
            {
                ObjectIwantToPickUp.GetComponent<Rigidbody>().isKinematic=false;

                ObjectIwantToPickUp.transform.parent=null;

                hasItem=false;
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag=="object")
            {
                canpickup=true;
                ObjectIwantToPickUp=other.gameObject;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            canpickup=false;
        }

    }

