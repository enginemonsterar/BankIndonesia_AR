using UnityEngine;
using MonsterAR.Utility;

public class PrefsManager : Singleton<PrefsManager>
{
    public int Points {
        get { return PlayerPrefs.GetInt("Points",0); }
        set { PlayerPrefs.SetInt("Points",value); }
    }

    public int AudioActiveMode {
        get { return PlayerPrefs.GetInt("AudioActiveMode",1); }
        set { PlayerPrefs.SetInt("AudioActiveMode",value); }
    }
}
