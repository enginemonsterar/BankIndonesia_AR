using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationPanel : MonoBehaviour
{

    public enum InfoMode
    {
        PhotoMode, VideoMode
    }

    private InfoMode nowMode = InfoMode.PhotoMode;
    [SerializeField] private Image photoSwitchImage;
    [SerializeField] private Image videoSwitchImage;
    [SerializeField] private Sprite[] photoSwitchSprites;
    [SerializeField] private Sprite[] videoSwitchSprites;

    public void ChangeMode(){
        if(nowMode == InfoMode.PhotoMode){            
            ChangeToVideoMode();
        }
        else{            
            ChangeToPhotoMode();
        }
    }

    public void ChangeToPhotoMode(){
        nowMode = InfoMode.PhotoMode;
        //change sprite
        photoSwitchImage.sprite = photoSwitchSprites[1];
        videoSwitchImage.sprite = videoSwitchSprites[0];
    }

    public void ChangeToVideoMode(){
        nowMode = InfoMode.VideoMode;
        //change sprite
        photoSwitchImage.sprite = photoSwitchSprites[0];
        videoSwitchImage.sprite = videoSwitchSprites[1];        
    }

    
}
