using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    [SerializeField] private GameObject canvasFooter;

    [SerializeField] private GameObject closeButton;    
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private Camera targetCamera;

    [SerializeField] private MeshRenderer targetMaterialRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToFullScreen(){
        videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
        videoPlayer.targetCamera = this.targetCamera;
        videoPlayer.aspectRatio = VideoAspectRatio.Stretch;

        closeButton.SetActive(true);

        canvasFooter.SetActive(false);
    }

    public void CloseFullScreen(){
        videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = this.targetMaterialRenderer;
        

        closeButton.SetActive(false);

        canvasFooter.SetActive(true);
    }
}
