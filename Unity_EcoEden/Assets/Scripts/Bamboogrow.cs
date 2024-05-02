using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooGrow : MonoBehaviour
{
    public BambooSeedInteraction seed;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Seed")
        {
            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        seed.Sink();

        yield return new WaitForSeconds(2f);

        GetComponent<Animator>().SetTrigger("grow");
            
        //Need to fix timing here
        SoundManager.S.BambooGrow(this.gameObject);
    }
}
