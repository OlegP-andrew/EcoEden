using UnityEngine;
using System.Collections;

public class BambooSeedInteraction : MonoBehaviour
{
    public Transform plantBuddy;
    private bool isPushing;
    private Rigidbody seedRigidbody;
    public float torqueMagnitude;
    private Vector3 pushDir;
    private Animator anim;

    private void Start()
    {
        seedRigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (isPushing)
        {
            MoveSeed();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPushing = true;
            pushDir = transform.position - plantBuddy.position;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPushing = false;
        }
    }

    public void MoveSeed()
    {
        Quaternion rotation = Quaternion.Euler(0, 90f, 0);
        Vector3 rotatedVector = rotation * pushDir;
        seedRigidbody.AddTorque(rotatedVector * torqueMagnitude);
    }

    public void Sink()
    {
        anim.SetTrigger("play");
    }
}
