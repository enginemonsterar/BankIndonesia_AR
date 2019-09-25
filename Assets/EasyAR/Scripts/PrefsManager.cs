using UnityEngine;
using MonsterAR.Utility;

public class PrefsManager : Singleton<PrefsManager>
{
    public int AudioActiveMode {
        get { return PlayerPrefs.GetInt("AudioActiveMode",1); }
        set { PlayerPrefs.SetInt("AudioActiveMode",value); }
    }
}
