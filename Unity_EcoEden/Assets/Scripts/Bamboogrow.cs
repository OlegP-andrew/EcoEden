using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboogrow : MonoBehaviour
{
    public GameObject bamboo;
    public bool seed = false;
    public bool bot = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
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
