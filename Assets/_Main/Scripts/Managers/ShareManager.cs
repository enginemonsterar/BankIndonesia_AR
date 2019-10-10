using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using VoxelBusters.NativePlugins;
using VoxelBusters.Utility;
using VoxelBusters.NativePlugins.Demo;

public class ShareManager : MonoBehaviour
{
    private string m_shareImageRelativePath = "LogoShare.png";
    // Start is called before the first frame update
    
    public void Share(){
        ShareImageOnSocialNetwork ();
    }

    private void ShareImageOnSocialNetwork ()
    {
        // Create share sheet
        SocialShareSheet _shareSheet 	= new SocialShareSheet();	
        _shareSheet.Text				= "Ayo Main ke Musium Bank Indonesia";
        _shareSheet.AttachImageAtPath(GetImageFullPath());
        
        // Show composer
        NPBinding.UI.SetPopoverPointAtLastTouchPosition();
        NPBinding.Sharing.ShowView(_shareSheet, FinishedSharing);
    }

    private void FinishedSharing (eShareResult _result)
    {
        // AddNewResult("Finished sharing");
        // AppendResult("Share Result = " + _result);
    }

    private string GetImageFullPath ()
    {
        return Application.streamingAssetsPath + "/" + m_shareImageRelativePath;
    }
    
}
