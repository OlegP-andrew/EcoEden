using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] float bounceForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Fog"))
        {
            // TODO: Play animation
        }
    }
}
