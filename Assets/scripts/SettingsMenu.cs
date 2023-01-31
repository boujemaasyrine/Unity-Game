using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

  //  public Slider musicSlider;
  // public Slider soundSlider;

  //  public void Start()
  // {
   //     audioMixer.GetFloat("Music", out float musicValueForSlider);
   //     musicSlider.value = musicValueForSlider;

   //     audioMixer.GetFloat("Sound", out float soundValueForSlider);
   //     soundSlider.value = soundValueForSlider;


  //  }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // public void SetSoundVolume(float volume)
    // {
    //   audioMixer.SetFloat("Sound", volume);
    // }
    //
    //  public void SetFullScreen(bool isFullScreen)
    //{
    //  Screen.fullScreen = isFullScreen;
    //}


    //public void ClearSavedData()
    //{
    //  PlayerPrefs.DeleteAll();
    //}

   
}
