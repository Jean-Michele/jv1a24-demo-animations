using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeReference] Animator door;
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {   
        if(other.CompareTag("Player")){
                print("Open door!");
                door.SetBool("IsOpen", true);
            }
        }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player")){
            print("Close door");
            door.SetBool("IsOpen", false);
            }
        }
}