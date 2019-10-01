using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using MonsterAR.Utility;

public class VideoManager : Singleton<VideoManager>
{
    private int nowVideoPlayerIndex;
    private bool inFullScreen;

    private bool onTrackingMarker;
    [SerializeField] private VideoPlayer[] videoPlayers;
    [SerializeField] private GameObject canvasFooter;
    [SerializeField] private GameObject closeButton;    
    [SerializeField] private Camera targetCamera;
    [SerializeField] private MeshRenderer[] targetMaterialRenderers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PrefsManager.Instance.AudioActiveMode == 1){
            
            videoPlayers[nowVideoPlayerIndex].SetDirectAudioMute(0,false);
        }else
        {
            videoPlayers[nowVideoPlayerIndex].SetDirectAudioMute(0,true);
        }
    }

    public void SetIndex(int index){
        nowVideoPlayerIndex = index;
        
    }

    public void DeactiveVideo(){
        videoPlayers[nowVideoPlayerIndex].gameObject.SetActive(false);
    }

    public void ChangeToFullScreen(){


        inFullScreen = true;

        videoPlayers[nowVideoPlayerIndex].renderMode = VideoRenderMode.CameraNearPlane;
        videoPlayers[nowVideoPlayerIndex].targetCamera = this.targetCamera;
        videoPlayers[nowVideoPlayerIndex].aspectRatio = VideoAspectRatio.Stretch;

        closeButton.SetActive(true);

        

        canvasFooter.SetActive(false);
    }

    public void CloseFullScreen(){

        inFullScreen = false;

        videoPlayers[nowVideoPlayerIndex].renderMode = VideoRenderMode.MaterialOverride;
        videoPlayers[nowVideoPlayerIndex].targetMaterialRenderer = this.targetMaterialRenderers[nowVideoPlayerIndex];
        
        closeButton.SetActive(false);

        canvasFooter.SetActive(true);

        if(!onTrackingMarker){
            DeactiveVideo();
        }
    }

    public bool GetInFullScreen(){
        return this.inFullScreen;
    }

    public void SetOnTrackingMarker(bool value){
        onTrackingMarker = value;
    }
}
