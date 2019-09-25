using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Michsky.UI.ModernUIPack;

public class QuizManager : MonoBehaviour
{
    private int nowQuesIndex;
    private List<Question> questions = new List<Question>();
    [SerializeField] private SwitchManager[] switchManagers;

    private bool[] checkQuestHasChoosed = new bool[]{false,false};

    [Header("UI")]
    [SerializeField] private Text questText;
    [SerializeField] private Image questImage;
    [SerializeField] private Sprite[] questSprites;
    [SerializeField] private Text[] firstOptionTexts;
    [SerializeField] private Text[] secondOptionTexts;

    [SerializeField] private Image[] resultImages;
    [SerializeField] private Sprite[] resultSprites;
    [SerializeField] private Button answerButton;
    

    [Header("Animator")]
    [SerializeField] private Animator pointAnimator;

    // Start is called before the first frame update
    void Start()
    {
        AssignQuestion();
        SetQuest(0);
    }

    
    public void CheckAnswer(){

        Question question = questions[nowQuesIndex];

        bool anyTrue = false;

        //Check First Answer
        resultImages[0].gameObject.SetActive(true);
        if(switchManagers[0].isOn == (question.GetRealAnswer()[0] == 1)){
            resultImages[0].sprite = resultSprites[1];
            anyTrue = true;
        }else{
            resultImages[0].sprite = resultSprites[0];
        }

        //Check Second Answer
        resultImages[1].gameObject.SetActive(true);
        if(switchManagers[1].isOn == (question.GetRealAnswer()[1] == 1)){
            resultImages[1].sprite = resultSprites[1];
            anyTrue = true;
        }else{
            resultImages[1].sprite = resultSprites[0];
        }

        if(anyTrue){
            pointAnimator.SetTrigger("AddScore");
        }
    }

    
    public void ChooseAnswer(int index){
        checkQuestHasChoosed[index] = true;

        if(checkQuestHasChoosed[0] == true && checkQuestHasChoosed[1] == true){
            answerButton.interactable = true;
        }
    }

    void SetQuest(int index){
        nowQuesIndex = index;
        questImage.sprite = questSprites[nowQuesIndex];
        questText.text = questions[nowQuesIndex].GetQuest();
        firstOptionTexts[0].text = questions[nowQuesIndex].GetFirstOptions()[0];
        firstOptionTexts[1].text = questions[nowQuesIndex].GetFirstOptions()[1];

        secondOptionTexts[0].text = questions[nowQuesIndex].GetSecondOptions()[0];
        secondOptionTexts[1].text = questions[nowQuesIndex].GetSecondOptions()[1];
    }


    void AssignQuestion(){
        questions.Add(new Question(
            "Siapakah tokoh pada gambar disamping?",
            new string[]{"Megawati","Sri Mulyani"},
            new string[]{"Menteri Keuangan","Menteri Kelautan"},
            new int[]{1,0}
        ));
    }
}
