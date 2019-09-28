using UnityEngine;
using MonsterAR.Utility;

public class PrefsManager : Singleton<PrefsManager>
{

    [SerializeField] private bool reset;
    void Start(){
        if(reset)
            PlayerPrefs.DeleteAll();
    }
    public int Points {
        get { return PlayerPrefs.GetInt("Points",0); }
        set { PlayerPrefs.SetInt("Points",value); }
    }

    public int AudioActiveMode {
        get { return PlayerPrefs.GetInt("AudioActiveMode",1); }
        set { PlayerPrefs.SetInt("AudioActiveMode",value); }
    }

    public int PaperMoneyColletions {
        get { return PlayerPrefs.GetInt("PaperMoneyColletions",0); }
        set { PlayerPrefs.SetInt("PaperMoneyColletions",value); }
    }

    public int CoinMoneyColletions {
        get { return PlayerPrefs.GetInt("CoinMoneyColletions",0); }
        set { PlayerPrefs.SetInt("CoinMoneyColletions",value); }
    }
}
