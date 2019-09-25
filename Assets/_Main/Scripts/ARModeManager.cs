using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class ARModeManager : Singleton<ARModeManager>
{
    [Header("Main")]
    [SerializeField] private GameObject arModeImageTargets;

    [Header("UI")]
    [SerializeField] private GameObject arModeFooterToolHolder;
    
    
    public void ActivateMode(){
        arModeFooterToolHolder.SetActive(true);
        arModeFooterToolHolder.SetActive(true);
    }

    public void DeActivateMode(){
        arModeFooterToolHolder.SetActive(false);
        arModeFooterToolHolder.SetActive(false);
    }
}
