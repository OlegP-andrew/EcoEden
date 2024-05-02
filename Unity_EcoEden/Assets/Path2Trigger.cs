using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path2Trigger : MonoBehaviour
{
    
    private bool isPath2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SoundManager.S.Path2Check(isPath2);
        
        // Debug.Log("isPath2 " + isPath2);
    }
    
    private void OnTriggerStay(Collider other)
    {
        isPath2 = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isPath2 = false;
    }
}
