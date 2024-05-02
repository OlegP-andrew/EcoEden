using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterEnding : MonoBehaviour
{
    public LevelLoader levelLoader;
    public GameObject plantBuddy;
    private Animator anim;

    private void Start()
    {
        anim = plantBuddy.GetComponent<Animator>();
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("celebrate");
            SoundManager.S.PlantBuddyCelebrate();
            levelLoader.LoadNextScene();
        }
    }
}