using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveTrigger : MonoBehaviour
{
    private bool isCave;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SoundManager.S.CaveAmbienceZones(isCave);
        
        //Debug.Log("isCave " + isCave);
    }

    private void OnTriggerStay(Collider other)
    {
        isCave = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isCave = false;
    }
}
