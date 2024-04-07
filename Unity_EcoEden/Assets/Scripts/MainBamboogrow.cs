using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBambooGrow : MonoBehaviour
{
    public GameObject bamboo;
    public bool seed = false;
    public bool bot = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Seed")
        {
            seed = true;
        }
        if (collision.gameObject.tag == "Player")
        {           
            bot = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (seed && bot)
        {
            bamboo.GetComponent<Animator>().SetTrigger("grow");
        }
    }
}
