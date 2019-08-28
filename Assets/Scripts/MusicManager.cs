using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] LevelMusicChangeArray;
    private AudioSource audioSource;

    void Awake() {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont Destroy On Load" + name);
    }
    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    void OnLevelWasLoaded(int level){
        AudioClip thisLevelMusic = LevelMusicChangeArray[level];

        Debug.Log("Playing clip : " + thisLevelMusic);

        if(thisLevelMusic){
            //if some music is attached
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play(); 
        }
    }
}
