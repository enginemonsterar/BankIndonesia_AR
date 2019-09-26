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

    [Header("UI")]
    [SerializeField] private Sprite[] typeSprites;
    [SerializeField] private Image[] typeImages;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeToMoneyType(){
        nowType = MoneyType.Paper;
        typeImages[0].sprite = typeSprites[1];
        typeImages[1].sprite = typeSprites[2];
    }
    public void ChangeToCoinType(){
        nowType = MoneyType.Coin;
        typeImages[0].sprite = typeSprites[0];
        typeImages[1].sprite = typeSprites[3];
    }
}
