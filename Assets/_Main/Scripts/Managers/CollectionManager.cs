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

    [SerializeField] private GameObject detailMoneyHolder;
    [SerializeField] private GameObject paperMoneyHolder;
    [SerializeField] private GameObject coinMoneyHolder;

    [SerializeField] private GameObject[] paperMoneyItems;
    [SerializeField] private GameObject[] coinMoneyItems;

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

            coinMoneyItems[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            coinMoneyItems[i].transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    public void ChangeToMoneyType(){
        nowType = MoneyType.Paper;
        typeImages[0].sprite = typeSprites[1];
        typeImages[1].sprite = typeSprites[2];

        paperMoneyHolder.SetActive(true);
        coinMoneyHolder.SetActive(false);

        detailMoneyHolder.GetComponent<DetailMoney>().ActivateMoney(0,1);
    }
    public void ChangeToCoinType(){
        nowType = MoneyType.Coin;
        typeImages[0].sprite = typeSprites[0];
        typeImages[1].sprite = typeSprites[3];

        paperMoneyHolder.SetActive(false);
        coinMoneyHolder.SetActive(true);

        detailMoneyHolder.GetComponent<DetailMoney>().ActivateMoney(1,0);
    }
}
