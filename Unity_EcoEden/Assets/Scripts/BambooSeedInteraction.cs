using UnityEngine;
using System.Collections;

public class BambooSeedInteraction : MonoBehaviour
{
    public GameObject plantPrefab;
    public float pushForce = 5f;
    public float sinkDuration = 0.6f;
    public Transform plantBuddy;
    private bool isPushing = false;
    private float pushStartTime;
    private Rigidbody seedRigidbody;
    public float torqueMagnitude = 500f;

    // private void Start()
    // {
    //     seedRigidbody = GetComponent<Rigidbody>();
    // }

    // private void FixedUpdate()
    // {
    //     if (isPushing)
    //     {
    //         if (Time.time - pushStartTime >= sinkDuration)
    //         {
    //             SinkSeed();
    //         }
    //     }
    // }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //         isPushing = true;
    //         pushStartTime = Time.time;
    //         Vector3 dir = transform.position - plantBuddy.position;
    //         PushSeed(new Vector3(dir.x, 0f, dir.z));
    //     }
    // }

    // private void SinkSeed()
    // {
    //     isPushing = false;
    //     // GrowPlant();
    // }

    // private void GrowPlant()
    // {
    //     Vector3 pos = transform.position;
    //     GameObject newPlant = Instantiate(plantPrefab, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(90, 180, 0));

    //     StartCoroutine(GrowPlantCoroutine(newPlant));
    // }

    // private IEnumerator GrowPlantCoroutine(GameObject plant)
    // {
    //     float elapsedTime = 0f;
    //     Vector3 initialScale = plant.transform.localScale;
    //     Vector3 targetScale = new Vector3(2000f, 3000f, 2000f);
    //     float growthDuration = 5f; 

    //     while (elapsedTime < growthDuration)
    //     {
    //         plant.transform.localScale = Vector3.Lerp(initialScale, targetScale, elapsedTime / growthDuration);
    //         elapsedTime += Time.deltaTime;
    //         yield return null;
    //     }

    //     plant.transform.localScale = targetScale;
    // }

    // public void PushSeed(Vector3 direction)
    // {
    //     seedRigidbody.MovePosition(transform.position + direction * pushForce * Time.deltaTime);
    //     seedRigidbody.AddTorque((plantBuddy.transform.position - transform.position) * torqueMagnitude);
    // }
}
