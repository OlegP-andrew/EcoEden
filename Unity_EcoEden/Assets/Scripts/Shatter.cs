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
    public GameObject brokenCrystal;

    public float explosionForce;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (playerController._input.sprint)
            {
                collisionsCount++;
                if (collisionsCount >= requiredCollisions) ShatterOnSprint();
            }
        }
    }

    void ShatterOnSprint()
    {
        MeshRenderer rend = GetComponent<MeshRenderer>();
        if (rend != null) Destroy(rend);
        else return;

        ExplodeFragments(transform.position);
    }

    void ExplodeFragments(Vector3 center)
    {

        anim.SetBool("break", true);
        brokenCrystal.SetActive(true);
        
        SoundManager.S.CrystalShatter(this.gameObject);

        piecesRoot.SetActive(true);

        foreach (GameObject piece in pieces)
        {
            piece.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, center, 50f);
        }
    }
}
