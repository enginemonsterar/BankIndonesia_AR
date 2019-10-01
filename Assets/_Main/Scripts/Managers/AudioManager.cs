using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioListener audioListener;
    [SerializeField] private Image buttonImage;
    [SerializeField] private Sprite[] buttonSprites;

    void Update()
    {
        if(PrefsManager.Instance.AudioActiveMode == 1){                        
            audioListener.enabled = true;
            buttonImage.sprite = buttonSprites[1];
            AudioListener.volume = 1;
        }else
        {            
            audioListener.enabled = false;
            buttonImage.sprite = buttonSprites[0];
            AudioListener.volume = 0;
        }
    }
    public void ChangeAudioActiveMode(){
        if(PrefsManager.Instance.AudioActiveMode == 1){
            PrefsManager.Instance.AudioActiveMode = 0;
            AudioListener.volume = 0;
            buttonImage.sprite = buttonSprites[0];
            
        }else
        {
            PrefsManager.Instance.AudioActiveMode = 1;
            audioListener.enabled = true;
            AudioListener.volume = 1;
            buttonImage.sprite = buttonSprites[1];
        }
    }
}
