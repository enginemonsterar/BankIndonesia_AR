using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Michsky.UI.ModernUIPack;
using MonsterAR.Utility;

public class QuizManager : Singleton<QuizManager>
{
    [SerializeField] private GameObject quizPanel;
    [SerializeField] private SwitchManager[] switchManagers;
    [SerializeField] private AudioClip trueClip;
    private int nowQuesIndex;
    private List<Question> questions = new List<Question>();

    private bool[] checkQuestHasChoosed = new bool[]{false,false};

    [SerializeField] private GameObject flyItemWorld;

    [Header("UI")]

    
    [SerializeField] private Text questText;
    [SerializeField] private Image questImage;
    [SerializeField] private Sprite[] questSprites;
    [SerializeField] private Text[] firstOptionTexts;
    [SerializeField] private Text[] secondOptionTexts;

    [SerializeField] private Image[] resultImages;
    [SerializeField] private Sprite[] resultSprites;
    [SerializeField] private Button finishButton;

    [SerializeField] private GameObject[] defaultSwitchers;
    

    [Header("Animator")]
    [SerializeField] private Animator pointAnimator;
    [SerializeField] private Animator collectionAnimator;

    // Start is called before the first frame update
    void Start()
    {
        AssignQuestion();


        SetQuest(0);
        flyItemWorld.SetActive(false);
        quizPanel.SetActive(false);

        
    }

    public void CollectFlyingItem(int index){
        SetQuest(index);
        flyItemWorld.SetActive(false);
    }

    
    public void CheckAnswer(){

        Question question = questions[nowQuesIndex];

        bool anyTrue = false;

        int tempAddedPoints = 0;

        //Check First Answer
        resultImages[0].gameObject.SetActive(true);
        if(switchManagers[0].isOn == (question.GetRealAnswer()[0] == 1)){
            resultImages[0].sprite = resultSprites[1];
            anyTrue = true;
            tempAddedPoints += 100;
        }else{
            resultImages[0].sprite = resultSprites[0];
        }

        //Check Second Answer
        resultImages[1].gameObject.SetActive(true);
        if(switchManagers[1].isOn == (question.GetRealAnswer()[1] == 1)){
            resultImages[1].sprite = resultSprites[1];
            anyTrue = true;
            tempAddedPoints += 100;
        }else{
            resultImages[1].sprite = resultSprites[0];
        }

        if(anyTrue){
            pointAnimator.gameObject.SetActive(true);
            collectionAnimator.gameObject.SetActive(true);
            pointAnimator.transform.GetChild(0).GetComponent<Text>().text = "+" + tempAddedPoints;
            pointAnimator.SetTrigger("AddScore");
            collectionAnimator.SetTrigger("AddScore");
            PrefsManager.Instance.Points += tempAddedPoints;
            if(PrefsManager.Instance.PaperMoneyColletions < 8)
                PrefsManager.Instance.PaperMoneyColletions++;
            if(PrefsManager.Instance.CoinMoneyColletions < 8)
                PrefsManager.Instance.CoinMoneyColletions++;

            GetComponent<AudioSource>().PlayOneShot(trueClip);
            
        }

        //Disable Switcher
        switchManagers[0].GetComponent<Button>().interactable = false;
        switchManagers[1].GetComponent<Button>().interactable = false;

        //Disable Finish Button
        finishButton.interactable = false;

        StartCoroutine(ResetQuizPanel(1));
    }

    public void ResetQuizPanel_(){
        StartCoroutine(ResetQuizPanel(0));
    }

    IEnumerator ResetQuizPanel(float waitTime){

        yield return new WaitForSeconds(waitTime);

        //Enable Switcher Button
        switchManagers[0].GetComponent<Button>().interactable = true;
        switchManagers[1].GetComponent<Button>().interactable = true;

        //Deactive Switcher
        switchManagers[0].gameObject.SetActive(false);
        switchManagers[1].gameObject.SetActive(false);

        //Active Default Switcher
        defaultSwitchers[0].SetActive(true);
        defaultSwitchers[1].SetActive(true);

        //Disable Finish Button
        finishButton.interactable = false;

        //Deactive resultImage
        resultImages[0].gameObject.SetActive(false);
        resultImages[1].gameObject.SetActive(false);

        //Decative quiz pane;
        quizPanel.SetActive(false);

        //Active fly item world
        flyItemWorld.SetActive(true);

        //False choosedAnser
        checkQuestHasChoosed[0] = false;
        checkQuestHasChoosed[1] = false;
        
    }

    
    public void ChooseAnswer(int index){
        checkQuestHasChoosed[index] = true;

        if(checkQuestHasChoosed[0] == true && checkQuestHasChoosed[1] == true){
            finishButton.interactable = true;
        }
    }

    void SetQuest(int index){
        quizPanel.SetActive(true);
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
        questions.Add(new Question(
            "Siapakah tokoh pada gambar disamping?",
            new string[]{"Ir. Soekarno","Drs. Moh. Hatta"},
            new string[]{"Presiden Pertama Republik Indonesia","Wakil Presiden Republik Indonesia"},
            new int[]{0,0}
        ));
        questions.Add(new Question(
            "Apakah warna bendera Negara Republik Indonesia?",
            new string[]{"Biru","Merah "},
            new string[]{"Putih","Merah"},
            new int[]{1,0}
        ));
        questions.Add(new Question(
            "Pada tanggal dan tahun berapakah Indonesia Merdeka?",
            new string[]{"17 Agustus","17 Oktober"},
            new string[]{"2019","1945"},
            new int[]{0,1}
        ));
        questions.Add(new Question(
            "Bangunan apakah yang terdapat pada gambar di samping?",
            new string[]{"Perpustakaan","Museum"},
            new string[]{"Indonesia","Bank Indonesia"},
            new int[]{1,1}
        ));
        
    }
}
