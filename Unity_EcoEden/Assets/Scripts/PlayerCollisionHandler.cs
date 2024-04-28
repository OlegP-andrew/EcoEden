using System;
using System.Linq;
using FMODUnityResonance;
using NUnit.Framework.Constraints;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] float bounceForce;

    public LayerMask usethis;
    private string surfaceMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Fog"))
        {
            // TODO: Play animation
        }
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Collider[] myColliders = Physics.OverlapSphere(transform.position, 0.5f, usethis);
        if (myColliders != null)
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
