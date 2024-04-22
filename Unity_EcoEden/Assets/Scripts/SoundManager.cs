using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // EventInstances Defined
    private FMOD.Studio.EventInstance plantBuddyDriving;

    // Player Controller
    public PlayerController playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        // Set and start driving FMOD Instance
        plantBuddyDriving = FMODUnity.RuntimeManager.CreateInstance("event:/PlantBuddy/Driving");
        plantBuddyDriving.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Plant Buddy SFX
    public void PlantBuddyBabble()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/PlantBuddy/Babbling");
    }

    public void PlantBuddyDriveUpdate(bool isDriving, bool isSprinting)
    {
        
    }
}
