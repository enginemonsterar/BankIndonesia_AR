using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionManager : MonoBehaviour
{
    public enum MoneyType
    {
        Paper, Coin
    }

    private MoneyType nowType = MoneyType.Paper;

    [SerializeField] private GameObject[] paperMoneyItems;

    [Header("UI")]
    [SerializeField] private Sprite[] typeSprites;
    [SerializeField] private Image[] typeImages;


    
    void Start()
    {
             
        ChangeToMoneyType();
    }

    
    void Update()
    {
        for (int i = 0; i < PrefsManager.Instance.PaperMoneyColletions; i++)
        {
            paperMoneyItems[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            paperMoneyItems[i].transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    public void ChangeToMoneyType(){
        nowType = MoneyType.Paper;
        typeImages[0].sprite = typeSprites[1];
        typeImages[1].sprite = typeSprites[2];

        //active
        for (int i = 0; i < PrefsManager.Instance.PaperMoneyColletions; i++)
        {
            paperMoneyItems[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            paperMoneyItems[i].transform.GetChild(1).gameObject.SetActive(true);
        }
    }
    public void ChangeToCoinType(){
        nowType = MoneyType.Coin;
        typeImages[0].sprite = typeSprites[0];
        typeImages[1].sprite = typeSprites[3];
    }
}
