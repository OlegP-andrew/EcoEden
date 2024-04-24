using UnityEngine;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;

public class ShatterWall1 : MonoBehaviour
{
    public ThirdPersonController playerController;
    public EndingManager endingManager;

    public int requiredCollisions = 3;
    private int collisionsCount = 0;
    public GameObject piecesRoot;

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
        SoundManager.S.CrystalShatter(this.gameObject);
        
        MeshRenderer rend = GetComponent<MeshRenderer>();
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        if (rend != null) Destroy(rend);
        if (boxCollider != null) Destroy(boxCollider);

        piecesRoot.SetActive(true);
        endingManager.Path1Ending();
    }


}
