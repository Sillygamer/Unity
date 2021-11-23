using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered the cube");
    }
    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + "is still in the cube");
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + "has left the cube");
    }
}
