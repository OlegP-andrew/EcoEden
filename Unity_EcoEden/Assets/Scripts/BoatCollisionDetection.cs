using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCollisionDetection : MonoBehaviour
{
    public LeafBoat leafBoat;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            leafBoat.StartOff();
        }
    }
}
