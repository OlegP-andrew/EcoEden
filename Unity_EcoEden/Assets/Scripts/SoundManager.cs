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
    private FMOD.Studio.EventInstance autumnAmbience;
    private FMOD.Studio.EventInstance motherPlantAmbience;
    private FMOD.Studio.EventInstance blagoon;

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
        autumnAmbience = FMODUnity.RuntimeManager.CreateInstance("event:/AutumnScene/AutumnAmbience");
        motherPlantAmbience = FMODUnity.RuntimeManager.CreateInstance("event:/MotherPlantScene/MotherplantAmbience");

        StartAmbience(gamestate);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //UI

    public void UI1()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/UI/UI2");
    }

    //Voice Lines

    public void VoiceLog(int voice)
    {
        if (voice == 1)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Voicelines/Bamboo");
        } else if (voice == 2)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Voicelines/Autumn");

        } else if (voice == 3)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Voicelines/Cave1");

        } else if (voice == 4)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Voicelines/Motherplant");
        }

        //Debug.Log("VoiceLogCalled");

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

    public void PlantBuddyJump()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/PlantBuddy/Jump");
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
                autumnAmbience.start();
                break;
            case 3:
                caveAmbience.start();
                break;
            case 4:
                motherPlantAmbience.start();
                break;
        }
    }

    public void StopAmbience()
    {
        caveAmbience.stop(STOP_MODE.IMMEDIATE);
        bambooAmbience.stop(STOP_MODE.IMMEDIATE);
        autumnAmbience.stop(STOP_MODE.IMMEDIATE);
        motherPlantAmbience.stop(STOP_MODE.IMMEDIATE);
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
    }
    
    // Autumn Scene

    public void ButtonPress()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/AutumnScene/MushroomPress");
    }

    public void MushroomGrow(GameObject mushroom)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/AutumnScene/MushroomGrow", mushroom);
    }
    
    // Cave Scene
    public void CrystalShatter(GameObject brokenCrystal)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/CaveScene/CrystalShatter", brokenCrystal);
    }

    public void BlackLagoonStart(GameObject blackLagoon)
    {
        blagoon = FMODUnity.RuntimeManager.CreateInstance("event:/CaveScene/BlackLagoon");
        blagoon.start();
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(blagoon, blackLagoon.transform);
    }

    public void BlackLagoonStop()
    {
        blagoon.stop(STOP_MODE.ALLOWFADEOUT);
    }

    public void LagoonMonster(GameObject blackLagoon)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/CaveScene/LagoonMonster", blackLagoon);
    }
    
    public void EyeballSound(GameObject eyeball)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/CaveScene/Eyeball", eyeball);
    }

    public void LeafCurl(GameObject leaf)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/CaveScene/LeafCurl", leaf);
    }
    
}
