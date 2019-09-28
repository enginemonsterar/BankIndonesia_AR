using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCam : MonoBehaviour {
    public GameObject webCameraPlane;
    Camera cam;
    public WebCamTexture webCameraTexture;
    // Use this for initialization
    void Start () {
        cam = GetComponent<Camera>();
        //if (Application.isMobilePlatform)
        //{
        //    GameObject cameraParent = new GameObject("camParent");
        //    cameraParent.transform.position = this.transform.position;
        //    this.transform.parent = cameraParent.transform;
        //    cameraParent.transform.Rotate(Vector3.right, 90);
        //}

        Input.gyro.enabled = true;

        

        webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.requestedWidth = 1920;
        webCameraTexture.requestedHeight = 1080;
        webCameraTexture.filterMode = FilterMode.Trilinear;
        webCameraTexture.Play();

    }

    // Update is called once per frame
    void Update () {
        //float pos = (cam.nearClipPlane + 0.01f);

        //webCameraPlane.transform.position = cam.transform.position + cam.transform.forward * pos;
        //webCameraPlane.transform.LookAt(cam.transform);
        //webCameraPlane.transform.Rotate(90.0f, 0.0f, 0.0f);

        //float h = (Mathf.Tan(cam.fieldOfView * Mathf.Deg2Rad * 0.5f) * pos * 2f) / 10.0f;

        //webCameraPlane.transform.localScale = new Vector3(h * cam.aspect, 1.0f, h);

       

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
