using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooGrow : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Seed")
        {
            GetComponent<Animator>().SetTrigger("grow");
            
            //Need to fix timing here
            SoundManager.S.BambooGrow(this.gameObject);
        }
    }
}
