using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    public Slider volumeSlider;
    public LevelManager levelManager;
    public Slider difficultySilder;
    private MusicManager musicManager;
    
    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySilder.value = PlayerPrefsManager.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        musicManager.ChangeVolume(volumeSlider.value);
    }

    public void SaveAndExit(){
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySilder.value);
        levelManager.LoadLevel("01a Start");
    }

    public void SetDefaluts(){
        volumeSlider.value = 0.5f;
        difficultySilder.value = 2f;
    }
}
