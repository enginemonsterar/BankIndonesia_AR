using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailMoney : MonoBehaviour
{
    [SerializeField] private Image detailInfoImage;
    [SerializeField] private Sprite[] detailInfoSprites;
    public void ResetRotation(){
        transform.rotation = new Quaternion(0,0,0,0);        
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    

    public void ActivateMoney(int indexActive, int indexDeactive){
        // transform.GetChild(indexActive).gameObject.SetActive(true);
        // transform.GetChild(indexDeactive).gameObject.SetActive(false);

        detailInfoImage.sprite = detailInfoSprites[indexActive];
    }
}
