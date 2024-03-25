using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    [SerializeField] private Slider volume;
    public Toggle RTX;
    public Toggle DLSS;
    public Toggle CHEAT;

    public void Start()
    {
        LoadSettings();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volume.value;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("volume", AudioListener.volume);

    }
    public void LoadSettings()
    {
        if (PlayerPrefs.HasKey("volume"))
            volume.value = PlayerPrefs.GetFloat("volume");
        else
            volume.value = 1;

    }
}
