using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCollisionDetection : MonoBehaviour
{
    public LeafBoat leafBoat;
    private bool counter;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!counter) leafBoat.StartOff();
        }
        counter = true;
    }
}
