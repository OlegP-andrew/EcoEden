using System.Collections;
using System.Collections.Generic;
using FMOD;
using UnityEngine;

public class BambooEnding : MonoBehaviour
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
            UnityEngine.Debug.Log("gooooooo");
            anim.SetTrigger("celebrate");
            SoundManager.S.PlantBuddyCelebrate();
            levelLoader.LoadNextScene();
        }
    }
}
