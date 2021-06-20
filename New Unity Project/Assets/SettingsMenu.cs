using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    void Start()
    {     

        List<string> options = new List<string>();

        
    }





    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }


    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }


    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
