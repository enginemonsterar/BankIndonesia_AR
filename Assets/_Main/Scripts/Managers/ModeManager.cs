using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;

public class ModeManager : Singleton<ModeManager>
{

    public enum GameMode
    {
        ARMode, QuizMode
    }

    private GameMode nowMode = GameMode.ARMode;

    // Start is called before the first frame update
    void Start()
    {
        //DefaultMode is ARMode
        ChangeToARMode();
    }

    public void ChangeGameMode(){
        if(nowMode == GameMode.ARMode){            
            ChangeToQuizMode();
        }
        else{            
            ChangeToARMode();
        }
    }

    public void ChangeToARMode(){
        // Debug.Log("Change to ARMode");
        nowMode = GameMode.ARMode;
        //Activate ARMode
        ARModeManager.Instance.ActivateMode(); 
        //DeActivate QuizMode
        QuizModeManager.Instance.DeActivateMode(); 
    }

    public void ChangeToQuizMode(){
        // Debug.Log("QuizMode Active");
        nowMode = GameMode.QuizMode;

        //Activate QuizMode
        QuizModeManager.Instance.ActivateMode(); 
        //DeActivate ARMode
        ARModeManager.Instance.DeActivateMode(); 
    }
}
