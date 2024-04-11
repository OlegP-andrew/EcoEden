using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooGrow : MonoBehaviour
{
    public GameObject bamboo;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Seed")
        {
            bamboo.GetComponent<Animator>().SetTrigger("grow");
        }
    }
}
