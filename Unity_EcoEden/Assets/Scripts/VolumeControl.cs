using UnityEngine;
using UnityEngine.UI;
using FMOD.Studio;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = 0.5f;
    }

    void Update()
    {
        SetMasterVolume(volumeSlider.value);
    }

    public void SetMasterVolume(float volume)
    {
        Bus masterBus = FMODUnity.RuntimeManager.GetBus("bus:/");
        masterBus.setVolume(volume);
        
        Debug.Log(volume);
    }
}
