using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Collect(int index){
        QuizManager.Instance.CollectFlyingItem(index);
        Destroy(this.gameObject);
    }
}
