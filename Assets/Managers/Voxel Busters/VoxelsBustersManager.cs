//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using VoxelBusters;
//using VoxelBusters.NativePlugins;

//public class VoxelsBustersManager : MonoBehaviour
//{

//    public void ShareScreenShot()
//    {
//        ShareScreenShotUsingShareSheet();
//    }


//    private void ShareScreenShotUsingShareSheet()
//    {
//        // Create share sheet
//        ShareSheet _shareSheet = new ShareSheet();
//        _shareSheet.Text = "https://play.google.com/store/apps/details?id=com.Company.Game";//
//        //_shareSheet.URL = "";

//        // Attaching screenshot here
//        _shareSheet.AttachScreenShot();

//        // Show composer
//        NPBinding.UI.SetPopoverPointAtLastTouchPosition();
//        NPBinding.Sharing.ShowView(_shareSheet, FinishedSharing);
//    }

//    void FinishedSharing(eShareResult _result)
//    {
//        Debug.Log("Finished sharing");
//        Debug.Log("Share Result = " + _result);
//    }



//}//class
