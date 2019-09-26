﻿using System.Collections;
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

    [SerializeField] private Text pointText;
       
    
    public void ActivateMode(){
        quizModeFooterPointHolder.SetActive(true);
        flyItemWorld.SetActive(true);        
        collectionButton.SetActive(true);

        /////

        pointText.text = PrefsManager.Instance.Points + "";

    }

    public void DeActivateMode(){
        quizModeFooterPointHolder.SetActive(false);
        flyItemWorld.SetActive(false);
        collectionButton.SetActive(false);
        
    }
}