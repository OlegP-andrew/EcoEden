using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.SceneManagement;

public class LeafBoat : MonoBehaviour
{
    public Transform plantBuddy;
    public GameObject plantBuddy1;
    public GameObject player;

    private ThirdPersonController thirdPersonController;
    private Animator anim;
    private bool constraint;
    private Vector3 positionOffset;
    // private BoxCollider buddyCollider;

    public void Start()
    {
        anim = GetComponent<Animator>();
        thirdPersonController = player.GetComponent<ThirdPersonController>();
        // buddyCollider = plantBuddy1.GetComponent<BoxCollider>();
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
        yield return new WaitForSeconds(1f);

        positionOffset = transform.position - plantBuddy.position;

        anim.SetTrigger("go");
        yield return new WaitForSeconds(2f);

        constraint = true;
        thirdPersonController.MoveSpeed /= 1.5f;
        thirdPersonController.JumpHeight = 0f;
        // buddyCollider.size = new Vector3(0.2f, 0.142f, 0.26f);
        thirdPersonController.enabled = true;

        yield return new WaitForSeconds(60f);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
