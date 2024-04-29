using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleTarget : MonoBehaviour
{
    public Transform plantBuddy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(plantBuddy.position.x, plantBuddy.position.y + 10f, plantBuddy.position.z);
        transform.position = pos;
    }
}
