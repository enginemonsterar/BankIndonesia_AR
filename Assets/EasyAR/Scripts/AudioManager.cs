using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioListener audioListener;

    void Awake()
    {
        
    }
    public void ChangeAudioActiveMode(){
        if(PrefsManager.Instance.AudioActiveMode == 1){
            PrefsManager.Instance.AudioActiveMode = 0;
            audioListener.enabled = false;
        }else
        {
            PrefsManager.Instance.AudioActiveMode = 1;
            audioListener.enabled = true;
        }
    }
}
