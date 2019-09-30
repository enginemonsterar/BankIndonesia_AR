using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Michsky.UI.ModernUIPack;

public class InformationPanel : MonoBehaviour
{

    public enum InfoMode
    {
        PhotoMode, VideoMode
    }

    private InfoMode nowMode = InfoMode.PhotoMode;

    [SerializeField] private SwitchManager mainSwitcherManager;
    [SerializeField] private Image photoSwitchImage;
    [SerializeField] private Image videoSwitchImage;
    [SerializeField] private Sprite[] photoSwitchSprites;
    [SerializeField] private Sprite[] videoSwitchSprites;

    [SerializeField] private GameObject infoBox;

    [SerializeField] private GameObject photoPlane;
    [SerializeField] private GameObject videoPlane;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        if(nowMode == InfoMode.VideoMode)
        ChangeToVideoMode();
    }


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

        photoPlane.SetActive(true);
        videoPlane.SetActive(false);

        infoBox.GetComponent<AudioSource>().UnPause();        
    }

    public void ChangeToVideoMode(){
        nowMode = InfoMode.VideoMode;
        //change sprite
        photoSwitchImage.sprite = photoSwitchSprites[0];
        videoSwitchImage.sprite = videoSwitchSprites[1];        

        photoPlane.SetActive(false);
        videoPlane.SetActive(true);

        infoBox.GetComponent<AudioSource>().Pause();
    }

    
}
