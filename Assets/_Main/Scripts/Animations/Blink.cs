using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
    private Image image;

    void Awake(){
        image = GetComponent<Image>();
    }
    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        StartCoroutine(Blinking());
    }

    IEnumerator Blinking(){
        float gapTime = 0.1f;        
        for (int i = 0; i < 5; i++)
        {            
            image.enabled = false;
            yield return new WaitForSeconds(gapTime);
            image.enabled = true;
            yield return new WaitForSeconds(gapTime);
        }

        
    }
}
