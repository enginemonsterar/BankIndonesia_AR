using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClampUI : MonoBehaviour
{
    
    [SerializeField] private GameObject UIObject;
    
    void Awake(){
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 uiWorldPos = Camera.main.WorldToScreenPoint(UIObject.transform.position);
        transform.position = uiWorldPos;
    }
}
