using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverSoundEmitter : MonoBehaviour
{

    public GameObject riverEmitter;
    public Collider riverCollider;
    public GameObject player;
    private Vector3 emitterLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        emitterLocation = riverCollider.ClosestPoint(player.transform.position);
        riverEmitter.transform.position = emitterLocation;
        
        //Debug.Log("player transform " + player.transform.position + " emitterLocation " + emitterLocation);
    }
}
