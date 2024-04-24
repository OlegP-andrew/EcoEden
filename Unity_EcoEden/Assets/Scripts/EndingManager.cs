using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public PlayerRespawner playerRespawner;
    public Transform player;
    public LayerMask path2Layer;

    // public GameObject path1;
    public GameObject path2;
    // public GameObject path3;

    // private Animator path1Animator;
    private Animator path2Animator;
    private Vector3 respawnPosition;

    private float sphereRadius = 0.73f;
    private float GroundedOffset = 0.14f;

    void Start()
    {
        path2Animator = path2.GetComponent<Animator>();
        respawnPosition = new Vector3(27.97621f, -14.452f, 72.4892f);
    }


    void Update()
    {
        Vector3 spherePosition = new Vector3(player.position.x, 1.73f + GroundedOffset,
            player.position.z);
        if (Physics.CheckSphere(spherePosition, sphereRadius, path2Layer))
        {
            Path2Ending();
        }
    }

    private void Path2Ending()
    {
        StartCoroutine(PlayPath2Ending());
    }

    private IEnumerator PlayPath2Ending()
    {
        Debug.Log("good");
        yield return new WaitForSeconds(8f);
        path2Animator.SetTrigger("play");
        yield return new WaitForSeconds(10f);
        playerRespawner.RespawnPlayer(respawnPosition);
    }
}
