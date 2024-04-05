using UnityEngine;
using StarterAssets;
using System.Collections.Generic;

public class Shatter : MonoBehaviour
{
    Animator anim;
    public ThirdPersonController playerController;
    public int requiredCollisions = 3;
    private int collisionsCount = 0;
    public List<GameObject> pieces = new List<GameObject>();
    public GameObject piecesRoot;

    public float explosionForce = 10f;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (playerController.isSprinting)
            {
                collisionsCount++;
                if (collisionsCount >= requiredCollisions) ShatterOnSprint();
            }
        }
    }

    void ShatterOnSprint()
    {
        MeshRenderer rend = GetComponent<MeshRenderer>();
        if (rend != null) rend.enabled = false;
        ExplodeFragments(transform.position);
    }

    void ExplodeFragments(Vector3 center)
    {
        Debug.Log("good");
        piecesRoot.SetActive(true);

        foreach (GameObject piece in pieces)
        {
            piece.transform.position = center + Random.insideUnitSphere * 0.5f;

            Rigidbody rb = piece.AddComponent<Rigidbody>();
            rb.AddExplosionForce(explosionForce, center, 5f);
            anim.SetBool("break", true);

        }
    }
}
