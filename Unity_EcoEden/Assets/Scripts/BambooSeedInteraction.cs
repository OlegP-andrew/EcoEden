using UnityEngine;
using System.Collections;

public class BambooSeedInteraction : MonoBehaviour
{
    public Transform plantBuddy;
    private bool isPushing;
    private Rigidbody seedRigidbody;
    public float torqueMagnitude;
    private Vector3 pushDir;

    private void Start()
    {
        seedRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isPushing)
        {
            MoveSeed();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPushing = true;
            pushDir = transform.position - plantBuddy.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPushing = false;
        }
    }

    public void MoveSeed()
    {
        seedRigidbody.AddTorque((Vector3.up) * torqueMagnitude);
    }
}
