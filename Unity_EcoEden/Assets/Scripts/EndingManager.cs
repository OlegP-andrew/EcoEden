using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public PlayerRespawner playerRespawner;
    public GameObject plantBuddy;
    public Transform player;
    public LayerMask path2Layer;

    public GameObject path1;
    public GameObject path2;

    private Animator path1Animator;
    private Animator path2Animator;
    private Animator plantBuddyAnim;
    private Vector3 respawnPosition;

    void Start()
    {
        plantBuddyAnim = plantBuddy.GetComponent<Animator>();
        path1Animator = path1.GetComponent<Animator>();
        path2Animator = path2.GetComponent<Animator>();
        respawnPosition = new Vector3(10.36f, 0f, -250.92f);
    }

    public void Path1Ending()
    {
        StartCoroutine(PlayPath1Ending());
    }

    public void Path2Ending()
    {
        StartCoroutine(PlayPath2Ending());
    }

    private IEnumerator PlayPath1Ending()
    {
        yield return new WaitForSeconds(15f);
        path1Animator.SetTrigger("play");

        yield return new WaitForSeconds(5f);
        plantBuddyAnim.SetTrigger("afraid");

        yield return new WaitForSeconds(5f);
        playerRespawner.RespawnPlayer(respawnPosition);
    }

    private IEnumerator PlayPath2Ending()
    {
        yield return new WaitForSeconds(10f);
        path2Animator.SetTrigger("play");

        yield return new WaitForSeconds(11f);
        plantBuddyAnim.SetTrigger("afraid");

        yield return new WaitForSeconds(5f);
        playerRespawner.RespawnPlayer(respawnPosition);
    }
}
