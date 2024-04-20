using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneShotAttatchedTest : MonoBehaviour
{
    public GameObject cube;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/CaveScene/CrystalShatter", cube);
        }
    }
}
