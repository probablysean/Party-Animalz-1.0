using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    static public float volume1;
    static float i = 0f;

    [SerializeField] Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        if(i != 1f)
        {
            volume1 = .5f;
            i = i + 1;
        }

        volumeSlider.value = volume1;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Save()
    {
        volume1 = volumeSlider.value;
    }
}
