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
        arModeImageTargets.SetActive(true);
        arModeFooterToolHolder.SetActive(true);
    }

    public void DeActivateMode(){
        arModeImageTargets.SetActive(false);
        arModeFooterToolHolder.SetActive(false);
    }
}
