using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class QuizModeManager : Singleton<QuizModeManager>
{
    [Header("Main")]
    [SerializeField] private GameObject flyItemWorld;

    [Header("UI")]
    [SerializeField] private GameObject quizModeFooterPointHolder;
    [SerializeField] private GameObject collectionButton;
       
    
    public void ActivateMode(){
        quizModeFooterPointHolder.SetActive(true);
        flyItemWorld.SetActive(true);        
        collectionButton.SetActive(true);
    }

    public void DeActivateMode(){
        quizModeFooterPointHolder.SetActive(false);
        flyItemWorld.SetActive(false);
        collectionButton.SetActive(false);
        
    }
}
