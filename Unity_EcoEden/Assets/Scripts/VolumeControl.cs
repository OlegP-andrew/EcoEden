using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1.0f);
    }

    void Update()
    {
        AudioListener.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    }
}
