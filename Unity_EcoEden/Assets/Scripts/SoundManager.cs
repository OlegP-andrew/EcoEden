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
    private FMOD.Studio.EventInstance bambooAmbience;
    
    // Plant Buddy
    private FMOD.Studio.EventInstance plantBuddyDriving;

    // Variables
    private int drive;
    private int sprint;
    private int ground;
    private int cave;
    private int path2;
    
    public int gamestate;
    //public int surfaceMaterial;

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
        bambooAmbience = FMODUnity.RuntimeManager.CreateInstance("event:/BambooScene/BambooAmbience");
        
        StartAmbience(gamestate);

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
    
    public void PlantBuddyAfraid()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/PlantBuddy/Afraid");
    }

    public void PlantBuddyCelebrate()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/PlantBuddy/Celebration");
    }
    
    public void PlantBuddyCollide()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/PlantBuddy/Collide");
    }
    
    public void PlantBuddyRandom()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/PlantBuddy/Random");
    }
    
    public void PlantBuddyDriveUpdate(bool isDriving, bool isSprinting, bool isGrounded)
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

        if (isGrounded == true)
        {
            ground = 1;
        }
        else
        {
            ground = 0;
        }

        plantBuddyDriving.setParameterByName("isDriving", drive);
        plantBuddyDriving.setParameterByName("isSprinting", sprint);
        plantBuddyDriving.setParameterByName("isGrounded", ground);
        
        //Debug.Log("ground " + ground);

    }

    public void PlantBuddyDriveGroundUpdate(string material)
    {
        plantBuddyDriving.setParameterByNameWithLabel("SurfaceMaterial", material);
    }
    
    // Ambience 

    public void StartAmbience(int gameState)
    {
        switch (gameState)
        {
            case 1:
                bambooAmbience.start();
                break;
            case 2:
                bambooAmbience.stop(STOP_MODE.ALLOWFADEOUT);
                break;
            case 3:
                caveAmbience.start();
                break;
            case 4:
                caveAmbience.stop(STOP_MODE.ALLOWFADEOUT);
                break;
        }
    }

    public void CaveAmbienceZones(bool isCave)
    {
        if (isCave == true)
        {
            cave = 1;
        }
        else
        {
            cave = 0;
        }

        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("isCave", cave);
    }

    public void Path2Check(bool isPath)
    {
        if (isPath == true)
        {
            path2 = 1;
        }
        else
        {
            path2 = 0;
        }

        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("isPath2", path2);
    }

        // Bamboo Scene

    public void CactusTentacles(GameObject cactus)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/BambooScene/CactusTentacles", cactus);
    }
    
    public void BambooGrow(GameObject bamboo)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/BambooScene/BambooGrow", bamboo);
        Debug.Log("BambooGrowCalled");
    }
    
    // Cave Scene
    public void CrystalShatter(GameObject brokenCrystal)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/CaveScene/CrystalShatter", brokenCrystal);
    }
}
