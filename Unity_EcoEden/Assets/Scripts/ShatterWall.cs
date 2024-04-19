using UnityEngine;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;

public class ShatterWall : MonoBehaviour
{
    public ThirdPersonController playerController;
    public int requiredCollisions = 3;
    private int collisionsCount = 0;
    public GameObject piecesRoot;

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
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        if (rend != null) Destroy(rend);
        if (boxCollider != null) Destroy(boxCollider);

        piecesRoot.SetActive(true);

        // StartCoroutine(PiecesDisappear());
    }

    private IEnumerator PiecesDisappear()
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(piecesRoot);
    }
}
