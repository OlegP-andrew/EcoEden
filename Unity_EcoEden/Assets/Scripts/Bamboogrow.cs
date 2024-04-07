using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooGrow : MonoBehaviour
{
    public GameObject bamboo;
    public bool seed = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Seed")
        {
            seed = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (seed)
        {
            Debug.Log("good");
            bamboo.GetComponent<Animator>().SetTrigger("grow");
        }
    }
}
