using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class QuizModeManager : Singleton<QuizModeManager>
{
    [Header("Main")]
    [SerializeField] private GameObject quizModeImageTargets;

    [Header("UI")]
    [SerializeField] private GameObject quizModeFooterPointHolder;
    [SerializeField] private GameObject quizPanel;
    
    
    public void ActivateMode(){
        quizModeFooterPointHolder.SetActive(true);
        quizModeImageTargets.SetActive(true);
        quizPanel.SetActive(true);
    }

    public void DeActivateMode(){
        quizModeFooterPointHolder.SetActive(false);
        quizModeImageTargets.SetActive(false);
        quizPanel.SetActive(false);
    }
}
