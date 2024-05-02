using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooGrow : MonoBehaviour
{
    public GameObject seed;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Seed")
        {
            StartCoroutine(Grow());
        }
    }

    private IEnumerator Grow()
    {
        yield return new WaitForSeconds(2f);
            
        GetComponent<Animator>().SetTrigger("grow");
        seed.SetActive(false);
            
        //Need to fix timing here
        SoundManager.S.BambooGrow(this.gameObject);
    }
}
