using System.Collections;
using System.Collections.Generic;
using System.IO;
using FMOD.Studio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager S;
    
    // EventInstances Defined

    // Ambiences
    private FMOD.Studio.EventInstance caveAmbience;
    
    // Plant Buddy
    private FMOD.Studio.EventInstance plantBuddyDriving;

    // Variables
    private int drive;
    private int sprint;

    private void Awake()
    {
        S = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        // Set and start driving FMOD Instance
        plantBuddyDriving = FMODUnity.RuntimeManager.CreateInstance("event:/PlantBuddy/Driving");
        plantBuddyDriving.start();

        caveAmbience = FMODUnity.RuntimeManager.CreateInstance("event:/CaveScene/CaveAmbience");
        StartAmbience(3);

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
        if (isDriving == true)
        {
            drive = 1;
        }
        else
        {
            drive = 0;
        }

        if (isSprinting == true)
        {
            sprint = 1;
        }
        else
        {
            sprint = 0;
        }

        plantBuddyDriving.setParameterByName("isDriving", drive);
        plantBuddyDriving.setParameterByName("isSprinting", sprint);

    }
    
    // Ambience 

    public void StartAmbience(int gameState)
    {
        switch (gameState)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                caveAmbience.start();
                break;
            case 4:
                caveAmbience.stop(STOP_MODE.ALLOWFADEOUT);
                break;
        }
    }
    
    // Cave Scene
    public void CrystalShatter(GameObject brokenCrystal)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/CaveScene/CrystalShatter", brokenCrystal);
    }
}
