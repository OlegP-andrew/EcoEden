using System;
using System.Linq;
using FMODUnityResonance;
using NUnit.Framework.Constraints;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using StarterAssets;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] float bounceForce;

    public LayerMask usethis;
    public ThirdPersonController thirdPersonController;
    private string surfaceMaterial;
    private Animator anim;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Crystal") ||
            collision.collider.CompareTag("Fog"))
        {
            if (thirdPersonController.isSprinting)
            {
                anim.SetTrigger("collide");
            }
        }
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Collider[] myColliders = Physics.OverlapSphere(transform.position, 0.5f, usethis);
        if (myColliders != null && myColliders.Length != 0)
        {
            switch (myColliders[0].tag)
            {
                case "water":
                    surfaceMaterial = "Water";
                    break;
                case "dirt":
                    surfaceMaterial = "Dirt";
                    break;
                case "stone":
                    surfaceMaterial = "Stone";
                    break;
                default:
                    surfaceMaterial = "Grass";
                    break;
            }

        }
    }
}
