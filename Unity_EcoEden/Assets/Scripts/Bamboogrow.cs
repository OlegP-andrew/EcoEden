using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooGrow : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("good");
        if (collision.gameObject.tag == "Seed")
        {
            GetComponent<Animator>().SetTrigger("grow");
        }
    }
}
