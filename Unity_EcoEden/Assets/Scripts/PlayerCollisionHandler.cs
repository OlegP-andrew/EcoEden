using System;
using System.Linq;
using FMOD;
using FMODUnityResonance;
using NUnit.Framework.Constraints;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using StarterAssets;
using Debug = UnityEngine.Debug;
using System.Collections;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] float bounceForce;

    public LayerMask usethis;
    public ThirdPersonController thirdPersonController;
    public PlayerRespawner playerRespawner;
    private string surfaceMaterial = "Dirt";
    private Animator anim;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Crystal") ||
            collision.collider.CompareTag("Fog"))
        {
            if (thirdPersonController.isSprinting)
            {
                anim.SetTrigger("collide");
            }
        }

        if (collision.collider.CompareTag("MazeLowerLevel"))
        {
            StartCoroutine(PrepRespanwn());
        }
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Collider[] myColliders = Physics.OverlapSphere(transform.position, 1f, usethis);
        if (myColliders != null && myColliders.Length != 0)
        {
            switch (myColliders[0].tag)
            {
                case "Water":
                    surfaceMaterial = "Water";
                    break;
                case "Dirt":
                    surfaceMaterial = "Dirt";
                    break;
                case "Stone":
                    surfaceMaterial = "Stone";
                    break;
                default:
                    surfaceMaterial = "Grass";
                    break;
            }
        }

        SoundManager.S.PlantBuddyDriveGroundUpdate(surfaceMaterial);
    }

    private IEnumerator PrepRespanwn()
    {
        yield return new WaitForSeconds(5f);

        Vector3 pos = new Vector3(89.15f, 57.69f, 7.06f);
        playerRespawner.RespawnPlayer(pos);
    }
    
}
    
