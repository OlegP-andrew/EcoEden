using System;
using System.Linq;
using FMOD;
using FMODUnityResonance;
using NUnit.Framework.Constraints;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using StarterAssets;
using Debug = UnityEngine.Debug;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] float bounceForce;

    public LayerMask usethis;
    public ThirdPersonController thirdPersonController;
    private string surfaceMaterial;
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

        //Debug.Log(collision.gameObject.tag);
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
            Debug.Log(myColliders[0].tag + " " + surfaceMaterial);
        }

        SoundManager.S.PlantBuddyDriveGroundUpdate(surfaceMaterial);
    }
    
}
    
