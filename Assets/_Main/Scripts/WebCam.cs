using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCam : MonoBehaviour {
    public GameObject webCameraPlane;
    Camera cam;
    public WebCamTexture webCameraTexture;
    // Use this for initialization
    void Start () {
        // cam = GetComponent<Camera>();
   

        Input.gyro.enabled = true;

        // webCameraTexture = new WebCamTexture();
        // webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        // webCameraTexture.requestedWidth = 1920;
        // webCameraTexture.requestedHeight = 1080;
        // webCameraTexture.filterMode = FilterMode.Trilinear;
        // webCameraTexture.Play();

    }

    // Update is called once per frame
    void Update () {      

        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        if (Input.gyro.enabled)
        {
            this.transform.localRotation = cameraRotation;
        }else
        {
            this.transform.localRotation = new Quaternion(0, 0, 0, 0);
        }
        
    }
    public void GyroEn(bool yes)
    {
        if (yes)
        {
            Input.gyro.enabled = true;
            
            
        }
        else
        {
            Input.gyro.enabled = false;
            this.transform.localRotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
