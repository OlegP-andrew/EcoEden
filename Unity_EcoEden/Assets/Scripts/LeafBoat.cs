using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.SceneManagement;

public class LeafBoat : MonoBehaviour
{
    public Transform plantBuddy;
    public GameObject plantBuddyObject;
    public GameObject player;
    public LevelLoader levelLoader;

    private ThirdPersonController thirdPersonController;
    private Animator anim;
    private bool constraint;
    private Vector3 positionOffset;

    public void Start()
    {
        anim = GetComponent<Animator>();
        thirdPersonController = player.GetComponent<ThirdPersonController>();
    }

    public void Update()
    {
        if (constraint) 
        {
            transform.position = plantBuddy.position + positionOffset;
        }
    }

    public void StartOff()
    {
        StartCoroutine(PrepareBoat());
    }

    public IEnumerator PrepareBoat()
    {
        thirdPersonController.enabled = false;

        anim.SetTrigger("boat");
        SoundManager.S.LeafCurl(this.gameObject);
        yield return new WaitForSeconds(1f);

        positionOffset = transform.position - plantBuddy.position;

        anim.SetTrigger("go");
        yield return new WaitForSeconds(2f);

        constraint = true;
        thirdPersonController.MoveSpeed /= 1.5f;
        thirdPersonController.JumpHeight = 0f;
        thirdPersonController.enabled = true;

        yield return new WaitForSeconds(80f);

        levelLoader.LoadNextScene();
    }
}
