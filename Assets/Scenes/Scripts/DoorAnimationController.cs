using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationController : MonoBehaviour
{

    public Animator animator;

    private void OnTriggerEnter(Collider other){
        if(other.tag== "Player"){
            animator.SetBool("DoorOpen",true);
        }

    }

   private void OnTriggerExit(Collider other){
        if(other.tag== "Player"){
            animator.SetBool("DoorOpen",false);
        }
   }
    
}
